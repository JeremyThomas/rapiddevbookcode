using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.LinqSupportClasses.ExpressionClasses;
using SD.LLBLGen.Pro.LinqSupportClasses.PrefetchPathAPI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Expression = System.Linq.Expressions.Expression;

// ReSharper disable CheckNamespace

namespace LLBLGen.Linq.Prefetch
// ReSharper restore CheckNamespace
{
  /// <summary>
  ///   https://github.com/richardhopton/LLBLGen.Linq.Prefetch
  /// </summary>
  public static class PrefetchExtensions
  {
    #region Expression Tree Methods

    // these methods don't do anything really - they just provide the declarations for the expression tree syntax

    public static IEnumerable<TEntity> FilterBy<TEntity>(this IEnumerable<TEntity> collection,
      Expression<Func<TEntity, Boolean>> filter)
      where TEntity : class, IEntityCore
    {
      return collection;
    }

    public static IEnumerable<TEntity> SortBy<TEntity>(this IEnumerable<TEntity> collection,
      Expression<Func<TEntity, Object>> order)
      where TEntity : class, IEntityCore
    {
      return collection;
    }

    public static IEnumerable<TEntity> SortByDescending<TEntity>(this IEnumerable<TEntity> collection,
      Expression<Func<TEntity, Object>> order)
      where TEntity : class, IEntityCore
    {
      return collection;
    }

    public static IEnumerable<TEntity> LimitTo<TEntity>(this IEnumerable<TEntity> collection,
      Int32 limit)
      where TEntity : class, IEntityCore
    {
      return collection;
    }

    public static IEnumerable<TEntity> Exclude<TEntity>(this IEnumerable<TEntity> collection,
      params Expression<Func<TEntity, Object>>[] excludeFields)
      where TEntity : class, IEntityCore
    {
      return collection;
    }

    public static IEnumerable<TEntity> Include<TEntity>(this IEnumerable<TEntity> collection,
      params Expression<Func<TEntity, Object>>[] includeFields)
      where TEntity : class, IEntityCore
    {
      return collection;
    }

    public static Object With<TEntity>(this IEnumerable<TEntity> collection,
      params Expression<Func<TEntity, Object>>[] prefetch)
      where TEntity : class, IEntityCore
    {
      return null;
    }

    public static Object With<TEntity>(this IEnumerable<TEntity> collection,
      IEnumerable<Expression<Func<TEntity, Object>>> prefetch)
      where TEntity : class, IEntityCore
    {
      return null;
    }

    public static TEntity FilterBy<TEntity>(this TEntity entity,
      Expression<Func<TEntity, Boolean>> filter)
      where TEntity : class, IEntityCore
    {
      return entity;
    }

    public static TEntity SortBy<TEntity>(this TEntity entity,
      Expression<Func<TEntity, Object>> order)
      where TEntity : class, IEntityCore
    {
      return entity;
    }

    public static TEntity SortByDescending<TEntity>(this TEntity entity,
      Expression<Func<TEntity, Object>> order)
      where TEntity : class, IEntityCore
    {
      return entity;
    }

    public static TEntity OrderBy<TEntity>(this TEntity entity,
      Expression<Func<TEntity, Object>> order)
      where TEntity : class, IEntityCore
    {
      return entity;
    }

    public static TEntity OrderByDescending<TEntity>(this TEntity entity,
      Expression<Func<TEntity, Object>> order)
      where TEntity : class, IEntityCore
    {
      return entity;
    }

    public static TEntity Exclude<TEntity>(this TEntity entity,
      params Expression<Func<TEntity, Object>>[] excludeFields)
      where TEntity : class, IEntityCore
    {
      return entity;
    }

    public static TEntity Include<TEntity>(this TEntity entity,
      params Expression<Func<TEntity, Object>>[] includeFields)
      where TEntity : class, IEntityCore
    {
      return entity;
    }

    public static Object With<TEntity>(this TEntity entity,
      params Expression<Func<TEntity, Object>>[] prefetch)
      where TEntity : class, IEntityCore
    {
      return null;
    }

    public static Object With<TEntity>(this TEntity entity,
      IEnumerable<Expression<Func<TEntity, Object>>> prefetch)
      where TEntity : class, IEntityCore
    {
      return null;
    }

    #endregion

    public static IQueryable<TEntity> With<TEntity>(this IQueryable<TEntity> query,
      params Expression<Func<TEntity, Object>>[] prefetch)
      where TEntity : class, IEntityCore
    {
      return With(query, prefetch.AsEnumerable());
    }

    public static IQueryable<TEntity> With<TEntity>(this IQueryable<TEntity> query,
      IEnumerable<Expression<Func<TEntity, Object>>> prefetch)
      where TEntity : class, IEntityCore
    {
      var creator = LinqUtils.GetElementCreator(query);
      var rootEdges = GetPathEdges(prefetch, creator, typeof (TEntity)).ToArray();
      return query.WithPath(rootEdges);
    }

    private static IEnumerable<IPathEdge> GetPathEdges(IEnumerable<Expression> expressions,
      IElementCreatorCore creator,
      Type sourceType)
    {
      return expressions
        .Select(e => GetPathEdge(e, creator, sourceType))
        .ToArray();
    }

    private static PathEdgeNonGeneric GetPathEdge(Expression expression,
      IElementCreatorCore creator,
      Type sourceType)
    {
      expression = UnwrapUnaryExpression(expression);
      var lambdaExpression = expression as LambdaExpression;
      if (lambdaExpression != null)
      {
        expression = lambdaExpression.Body;
      }
      var methodCallExpression = expression as MethodCallExpression;
      if (methodCallExpression != null)
      {
        return IsGenericTypeDefinition(methodCallExpression.Type, typeof (Expression<>))
          ? GetPathEdgeFromCompiledExpression(creator, sourceType, methodCallExpression)
          : GetPathEdgeFromMethodCallExpression(creator, sourceType, methodCallExpression);
      }
      var memberExpression = expression as MemberExpression;
      if (memberExpression != null)
      {
        return GetPathEdgeFromMemberExpression(creator, sourceType, memberExpression);
      }

      // if it gets here then something is wrong
      throw new Exception(String.Format("Cannot handle {0}", expression.GetType().Name));
    }

    private static bool IsGenericTypeDefinition(Type type, Type match)
    {
      return type.IsGenericType &&
             type.GetGenericTypeDefinition() == match;
    }

    private static PathEdgeNonGeneric GetPathEdgeFromMethodCallExpression(IElementCreatorCore creator,
      Type sourceType,
      MethodCallExpression expression)
    {
      var pathEdge = GetPathEdge(expression.Arguments[0], creator, sourceType);
      var targetEdge = pathEdge;
      while (targetEdge.ChildEdges.Any())
        targetEdge = (PathEdgeNonGeneric) targetEdge.ChildEdges[0];

      var methodName = expression.Method.Name;
      var argumentExpression = expression.Arguments[1];

      switch (methodName)
      {
        case "With":
        {
          AddChildEdges(creator, argumentExpression, targetEdge);
          break;
        }
        case "FilterBy":
        case "Where":
        {
          targetEdge.FilterLambda = GetExpression<LambdaExpression>(argumentExpression);
          break;
        }
        case "OrderBy":
        case "SortBy":
        {
          var sortClauseExpression = new SortClauseExpression(sourceType,
            SortOperator.Ascending,
            GetExpression<LambdaExpression>(argumentExpression));
          targetEdge.SortClauseExpressions.Add(sortClauseExpression);
          break;
        }
        case "OrderByDescending":
        case "SortByDescending":
        {
          var sortClauseExpression = new SortClauseExpression(sourceType,
            SortOperator.Descending,
            GetExpression<LambdaExpression>(argumentExpression));
          targetEdge.SortClauseExpressions.Add(sortClauseExpression);
          break;
        }
        case "LimitTo":
        case "Take":
        {
          var constantExpression = GetExpression<ConstantExpression>(argumentExpression);
          targetEdge.Limiter = (Int32) constantExpression.Value;
          break;
        }
        case "Include":
        {
          HandleIncludeExcludeFields(targetEdge,
            creator,
            GetExpression<NewArrayExpression>(argumentExpression).Expressions,
            false);
          break;
        }
        case "Exclude":
        {
          HandleIncludeExcludeFields(targetEdge,
            creator,
            GetExpression<NewArrayExpression>(argumentExpression).Expressions,
            true);
          break;
        }
        default:
          throw new Exception("Unknown method specified");
      }
      return pathEdge;
    }

    private static void AddChildEdges(IElementCreatorCore creator,
      Expression childExpression,
      PathEdgeNonGeneric targetEdge)
    {
      var destinationType = targetEdge.EndNodeType;
      var pathEdges = GetChildPathEdges(childExpression, creator, destinationType);
      targetEdge.ChildEdges.AddRange(pathEdges);
    }

    private static IEnumerable<IPathEdge> GetChildPathEdges(Expression expression,
      IElementCreatorCore creator,
      Type sourceType)
    {
      var expressions = GetExpressions(expression);
      return GetPathEdges(expressions, creator, sourceType);
    }

    private static IEnumerable<Expression> GetExpressions(Expression expression)
    {
      var newArrayExpression = UnwrapUnaryExpression(expression) as NewArrayExpression;
      return newArrayExpression != null ? newArrayExpression.Expressions : Expression.Lambda<Func<IEnumerable<Expression>>>(expression).Compile()();
    }

    private static PathEdgeNonGeneric GetPathEdgeFromMemberExpression(IElementCreatorCore creator,
      Type sourceType,
      MemberExpression expression)
    {
      var nodeType = expression.Expression.NodeType;
      var propertyName = expression.Member.Name;
      switch (nodeType)
      {
        case ExpressionType.Parameter:
        {
          var destinationType = DetermineEntityType(expression);
          return CreatePathEdge(creator, destinationType, sourceType, propertyName);
        }
        case ExpressionType.MemberAccess:
        case ExpressionType.Call:
        {
          var pathEdge = GetPathEdge(expression.Expression, creator, sourceType);
          var destinationType = DetermineEntityType(expression);
          var childEdge = CreatePathEdge(creator, destinationType, pathEdge.EndNodeType, propertyName);
          pathEdge.ChildEdges.Add(childEdge);
          return pathEdge;
        }
        case ExpressionType.Constant:
        {
          return GetPathEdgeFromCompiledExpression(creator, sourceType, expression);
        }
      }
      throw new Exception(String.Format("Cannot Handle NodeType: {0}", nodeType));
    }

    private static PathEdgeNonGeneric GetPathEdgeFromCompiledExpression(IElementCreatorCore creator,
      Type sourceType,
      Expression expression)
    {
      var resultExpression = Expression.Lambda<Func<Expression>>(expression).Compile()();
      return GetPathEdge(resultExpression, creator, sourceType);
    }

    private static PathEdgeNonGeneric CreatePathEdge(IElementCreatorCore creator,
      Type destinationType,
      Type sourceType,
      String propertyName)
    {
      var prefetchPathElement = new PathElementCreator
        (creator,
          destinationType,
          sourceType,
          propertyName)
        .CreatePrefetchElement();
      return new PathEdgeNonGeneric
      {
        EndNodeType = destinationType,
        PathElement = prefetchPathElement
      };
    }

    private static Type DetermineEntityType(Expression expression)
    {
      var type = expression.Type;
      return typeof (IEntityCore).IsAssignableFrom(type)
        ? type
        : LinqUtils.DetermineEntityTypeFromEntityCollectionType(type);
    }

    private static void HandleIncludeExcludeFields(PathEdgeNonGeneric targetEdge,
      IElementCreatorCore creator,
      IEnumerable<Expression> expressions,
      Boolean exclude)
    {
      var destinationType = targetEdge.EndNodeType;
      if (targetEdge.FieldsToExcludeInclude != null)
      {
        throw new Exception("There can only be one call to Exclude or Include in each part of the prefetch path.");
      }
      targetEdge.FieldsToExcludeInclude = new ExcludeIncludeFieldsList(exclude);
      var entity = LinqUtils.CreateEntityInstanceFromEntityType(destinationType, creator);
      var fields = expressions
        .Select(e => GetExpression<LambdaExpression>(e).Body)
        .Select(e => GetExpression<MemberExpression>(e).Member.Name)
        .Select(name => LinqUtils.GetFieldObject(entity, name));
      targetEdge.FieldsToExcludeInclude.AddRange(fields);
    }

    private static TExpression GetExpression<TExpression>(Expression expression)
      where TExpression : Expression
    {
      var result = UnwrapUnaryExpression(expression) as TExpression;
      if (result == null)
        throw new Exception(String.Format("Expected {0}", typeof (TExpression).Name));
      return result;
    }

    private static Expression UnwrapUnaryExpression(Expression expression)
    {
      var unaryExpression = expression as UnaryExpression;
      return unaryExpression != null ? unaryExpression.Operand : expression;
    }
  }
}