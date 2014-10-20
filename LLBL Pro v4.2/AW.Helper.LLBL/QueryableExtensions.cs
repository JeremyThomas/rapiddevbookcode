using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Expression = System.Linq.Expressions.Expression;

namespace AW.Helper.LLBL
{
  public static class QueryableExtensions
  {
    #region Custom extension methods

    /// <summary>
    ///   Gets the count of a query by projecting onto the primary keys and then doing a distinct count
    /// </summary>
    /// <typeparam name="T">EntityBase2</typeparam>
    /// <param name="query">The query.</param>
    /// <returns>Results of the query in an entity collection.</returns>
    public static int CountOnPrimaryKeys<T>(this IQueryable<T> query) where T : class, IEntityCore
    {
      var pkFields = EntityHelper.CreateEntity<T>().Fields.PrimaryKeyFields.OfType<IEntityFieldCore>();
      return pkFields.Count() == 1 ? query.CountColumn(pkFields.First()) : DistinctByFields(query, pkFields).Count();
    }

    /// <summary>
    ///   Projects the PKIDs as distinct onto a new version of T.
    /// </summary>
    /// <typeparam name="T">LLLB Entity</typeparam>
    /// <param name="query">The query.</param>
    /// <returns></returns>
    public static IQueryable<T> DistinctOnPrimaryKeys<T>(this IQueryable<T> query) where T : class, IEntityCore
    {
      // Get Primary Key Fields
      if (typeof (T).Implements(typeof (IEntity2)))
        return DistinctByFields(query, ((IEntity2) EntityHelper.CreateEntity<T>()).Fields.PrimaryKeyFields);
      return DistinctByFields(query, ((IEntity) EntityHelper.CreateEntity<T>()).Fields.PrimaryKeyFields);
    }

    private static IQueryable<T> DistinctByFields<T>(IQueryable<T> query, IEnumerable<IEntityFieldCore> fields) where T : class, IEntityCore
    {
      return query.Select(CreateFieldProjectionExpression<T>(fields)).Distinct();
    }

    public static int CountColumn<TSource>(this IQueryable<TSource> source, IEntityFieldCore field)
    {
      if (source == null) throw new ArgumentNullException("source");
      if (field == null) throw new ArgumentNullException("field");
      return source.CountColumn(CreateFieldProjectionExpression<TSource>(field), true);
    }

    /// <summary>
    ///   Adds a where clause to query based on the primary key fields of an entity.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <param name="query">The query.</param>
    /// <param name="entity">The entity.</param>
    /// <returns></returns>
    public static IQueryable<TEntity> AddPkWhereClauseToQuery<TEntity>(IQueryable<TEntity> query, TEntity entity) where TEntity : IEntityCore
    {
      return query == null
        ? null
        : LinqUtils.GetAllPkFieldsOfEntity(entity, false).Cast<IEntityFieldCore>().
          Aggregate(query, (current, pkfield) => current.Where(CreateBooleanLambdaExpression<TEntity>(pkfield)));
    }

    #endregion

    #region ExpressionHelpers

    private static MemberExpression MakeFieldMemberAccess<T>(Expression r, IFieldInfo field)
    {
      return MakeFieldMemberAccess<T>(r, field.Name);
    }

    private static MemberExpression MakeFieldMemberAccess<T>(Expression r, string name)
    {
      var propertyInfo = typeof (T).GetProperty(name);
      return Expression.MakeMemberAccess(r, propertyInfo);
    }

    private static MemberAssignment MakeFieldMemberAssignment<T>(Expression r, string name)
    {
      return Expression.Bind(typeof (T).GetProperty(name), MakeFieldMemberAccess<T>(r, name));
    }

    /// <summary>
    ///   Makes the field member assignments. Create a list of "PkField = r.PkField" expressions
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="r">The r.</param>
    /// <param name="fields">The fields.</param>
    /// <returns></returns>
    private static IEnumerable<MemberAssignment> MakeFieldMemberAssignments<T>(Expression r, IEnumerable<IEntityFieldCore> fields)
    {
      return fields.Select(pk => MakeFieldMemberAssignment<T>(r, pk.Name));
    }

    private static Expression<Func<T, T>> CreateFieldProjectionExpression<T>(IEnumerable<IEntityFieldCore> fields)
    {
      // Create parameter (the "r" in (r=>{})
      var r = Expression.Parameter(typeof (T), "r");
      var pkFieldExpressions = MakeFieldMemberAssignments<T>(r, fields);
      var memberInitExpression = Expression.MemberInit(Expression.New(typeof (T)), pkFieldExpressions);
      return Expression.Lambda<Func<T, T>>(memberInitExpression, r);
    }

    private static Expression<Func<T, object>> CreateFieldProjectionExpression<T>(IFieldInfo field)
    {
      // Create parameter (the "r" in (r=>{})
      var r = Expression.Parameter(typeof (T), "r");
      var pkFieldExpressions = Expression.Convert(MakeFieldMemberAccess<T>(r, field), typeof (object));
      return Expression.Lambda<Func<T, object>>(pkFieldExpressions, r);
    }

    /// <summary>
    ///   Creates a boolean lambda expression for a field in an entity.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <param name="field">The field.</param>
    /// <returns>A boolean lambda expression.</returns>
    private static Expression<Func<TEntity, bool>> CreateBooleanLambdaExpression<TEntity>(IEntityFieldCore field)
    {
      var pkvalue = field.CurrentValue;
      // Build the expression
      var param = Expression.Parameter(typeof (TEntity), "entity");
      var wcExpression = Expression.Equal(Expression.Property(param, field.Name),
        Expression.Constant(pkvalue));
      return Expression.Lambda<Func<TEntity, bool>>(wcExpression, param);
    }

    #endregion
  }
}