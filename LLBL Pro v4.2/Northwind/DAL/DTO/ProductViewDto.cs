using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.HelperClasses;

namespace Northwind.DAL.DTO
{
  public class ProductViewDto : PocoBase, IProduct
  {
    public Category? CategoryId { get; set; }
    public bool Discontinued { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public short? ReorderLevelZzz { get; set; }
    public int? SupplierId { get; set; }
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }
    public short? UnitsOnOrder { get; set; }

    public override string ToString()
    {
      var builder = new StringBuilder();
      builder.Append("{ CategoryId = ");
      builder.Append(CategoryId);
      builder.Append(", Discontinued = ");
      builder.Append(Discontinued);
      builder.Append(", ProductId = ");
      builder.Append(ProductId);
      builder.Append(", ProductName = ");
      builder.Append(ProductName);
      builder.Append(", QuantityPerUnit = ");
      builder.Append(QuantityPerUnit);
      builder.Append(", ReorderLevel = ");
      builder.Append(ReorderLevelZzz);
      builder.Append(", SupplierId = ");
      builder.Append(SupplierId);
      builder.Append(", UnitPrice = ");
      builder.Append(UnitPrice);
      builder.Append(", UnitsInStock = ");
      builder.Append(UnitsInStock);
      builder.Append(", UnitsOnOrder = ");
      builder.Append(UnitsOnOrder);
      builder.Append(" }");
      return builder.ToString();
    }

    public override bool Equals(object value)
    {
      var type = value as ProductViewDto;
      return (type != null) && EqualityComparer<Category?>.Default.Equals(type.CategoryId, CategoryId) && EqualityComparer<bool>.Default.Equals(type.Discontinued, Discontinued) && EqualityComparer<int>.Default.Equals(type.ProductId, ProductId) && EqualityComparer<string>.Default.Equals(type.ProductName, ProductName) && EqualityComparer<string>.Default.Equals(type.QuantityPerUnit, QuantityPerUnit) && EqualityComparer<short?>.Default.Equals(type.ReorderLevelZzz, ReorderLevelZzz) && EqualityComparer<int?>.Default.Equals(type.SupplierId, SupplierId) && EqualityComparer<decimal?>.Default.Equals(type.UnitPrice, UnitPrice) && EqualityComparer<short?>.Default.Equals(type.UnitsInStock, UnitsInStock) && EqualityComparer<short?>.Default.Equals(type.UnitsOnOrder, UnitsOnOrder);
    }

    public override int GetHashCode()
    {
      var num = 0x7a2f0b42;
      num = (-1521134295*num) + EqualityComparer<Category?>.Default.GetHashCode(CategoryId);
      num = (-1521134295*num) + EqualityComparer<bool>.Default.GetHashCode(Discontinued);
      num = (-1521134295*num) + EqualityComparer<int>.Default.GetHashCode(ProductId);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(ProductName);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(QuantityPerUnit);
      num = (-1521134295*num) + EqualityComparer<short?>.Default.GetHashCode(ReorderLevelZzz);
      num = (-1521134295*num) + EqualityComparer<int?>.Default.GetHashCode(SupplierId);
      num = (-1521134295*num) + EqualityComparer<decimal?>.Default.GetHashCode(UnitPrice);
      num = (-1521134295*num) + EqualityComparer<short?>.Default.GetHashCode(UnitsInStock);
      return (-1521134295*num) + EqualityComparer<short?>.Default.GetHashCode(UnitsOnOrder);
    }

    public ProductViewDto(IProductFull p)
      : this(
        p.CategoryId,
        p.Discontinued,
        p.ProductId,
        p.ProductName,
        p.QuantityPerUnit,
        p.ReorderLevel,
        p.SupplierId,
        p.UnitPrice,
        p.UnitsInStock,
        p.UnitsOnOrder
        )
    {
    }

    private ProductViewDto()
    {
    }

    private ProductViewDto(Category? categoryId, bool discontinued, int productId, string productName, string quantityPerUnit, short? reorderLevelZzz, 
      int? supplierId, decimal? unitPrice, short? unitsInStock, short? unitsOnOrder)
    {
      CategoryId = categoryId;
      Discontinued = discontinued;
      ProductId = productId;
      ProductName = productName;
      QuantityPerUnit = quantityPerUnit;
      ReorderLevelZzz = reorderLevelZzz;
      SupplierId = supplierId;
      UnitPrice = unitPrice;
      UnitsInStock = unitsInStock;
      UnitsOnOrder = unitsOnOrder;
    }

    /// <summary>
    /// Factory to produce ProductViewDtos via a constructor that takes a Product entity. 
    /// Note: ordering on the ProductViewDto fields will only work if the names match up with Product entity fields
    /// </summary>
    /// <param name="productEntities">The product entities.</param>
    /// <returns></returns>
    public static IQueryable<ProductViewDto> ProductViewDtoFactoryEntityConstructor(IQueryable<ProductEntity> productEntities)
    {
      return productEntities.Select(c => new ProductViewDto(c));
    }

    /// <summary>
    /// Factory to produce ProductViewDtos via a constructor that takes a Product entity. 
    /// </summary>
    /// <param name="productEntities">The product entities.</param>
    /// <returns></returns>
    public static IQueryable<ProductViewDto> ProductViewDtoFactoryPropertyProjection(IQueryable<ProductEntity> productEntities)
    {
      return from p in productEntities
             select new ProductViewDto
               {
                 CategoryId = p.CategoryId, Discontinued = p.Discontinued, ProductId = p.ProductId,
                 ProductName = p.ProductName, QuantityPerUnit = p.QuantityPerUnit, ReorderLevelZzz = p.ReorderLevel,
                 SupplierId = p.SupplierId, UnitPrice = p.UnitPrice, UnitsInStock = p.UnitsInStock, UnitsOnOrder = p.UnitsOnOrder
               };
    }

    /// <summary>
    /// Factory to produce ProductViewDtos via a constructor that takes Product entity fields
    /// Note: ordering on the ProductViewDto fields will only work if the names match up with constructor param names
    /// </summary>
    /// <param name="productEntities">The product entities.</param>
    /// <returns></returns>
    public static IQueryable<ProductViewDto> ProductViewDtoFactoryPropertiesViaConstructor(IQueryable<ProductEntity> productEntities)
    {
      return from p in productEntities
             select new ProductViewDto
               (
               p.CategoryId,
               p.Discontinued,
               p.ProductId,
               p.ProductName,
               p.QuantityPerUnit,
               p.ReorderLevel,
               p.SupplierId,
               p.UnitPrice,
               p.UnitsInStock,
               p.UnitsOnOrder
               );
    }
  }
}