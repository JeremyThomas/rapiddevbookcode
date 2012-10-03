using System;
using System.ComponentModel;
using Northwind.DAL.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.HelperClasses
{
  public interface IProduct : IEntity2
  {
    /// <summary> The CategoryId property of the Entity Product<br/><br/>
    /// MS_Description: Same entry as in Categories table.<br/></summary>
    /// <remarks>Mapped on  table field: "Products"."CategoryID"<br/>
    /// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
    /// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
    Nullable<Northwind.DAL.Category> CategoryId { get; set; }

    /// <summary> The Discontinued property of the Entity Product<br/><br/>
    /// MS_Description: Yes means item is no longer available.<br/></summary>
    /// <remarks>Mapped on  table field: "Products"."Discontinued"<br/>
    /// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
    /// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
    System.Boolean Discontinued { get; set; }

    /// <summary> The ProductId property of the Entity Product<br/><br/>
    /// MS_Description: Number automatically assigned to new product.<br/></summary>
    /// <remarks>Mapped on  table field: "Products"."ProductID"<br/>
    /// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
    /// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
    System.Int32 ProductId { get; set; }

    /// <summary> The ProductName property of the Entity Product<br/><br/></summary>
    /// <remarks>Mapped on  table field: "Products"."ProductName"<br/>
    /// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40<br/>
    /// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
    System.String ProductName { get; set; }

    /// <summary> The QuantityPerUnit property of the Entity Product<br/><br/>
    /// MS_Description: (e.g., 24-count case, 1-liter bottle).<br/></summary>
    /// <remarks>Mapped on  table field: "Products"."QuantityPerUnit"<br/>
    /// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
    /// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
    System.String QuantityPerUnit { get; set; }

    /// <summary> The ReorderLevel property of the Entity Product<br/><br/>
    /// MS_Description: Minimum units to maintain in stock.<br/></summary>
    /// <remarks>Mapped on  table field: "Products"."ReorderLevel"<br/>
    /// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
    /// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
    Nullable<System.Int16> ReorderLevel { get; set; }

    /// <summary> The SupplierId property of the Entity Product<br/><br/>
    /// MS_Description: Same entry as in Suppliers table.<br/></summary>
    /// <remarks>Mapped on  table field: "Products"."SupplierID"<br/>
    /// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
    /// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
    Nullable<System.Int32> SupplierId { get; set; }

    /// <summary> The UnitPrice property of the Entity Product<br/><br/></summary>
    /// <remarks>Mapped on  table field: "Products"."UnitPrice"<br/>
    /// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
    /// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
    Nullable<System.Decimal> UnitPrice { get; set; }

    /// <summary> The UnitsInStock property of the Entity Product<br/><br/></summary>
    /// <remarks>Mapped on  table field: "Products"."UnitsInStock"<br/>
    /// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
    /// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
    Nullable<System.Int16> UnitsInStock { get; set; }

    /// <summary> The UnitsOnOrder property of the Entity Product<br/><br/></summary>
    /// <remarks>Mapped on  table field: "Products"."UnitsOnOrder"<br/>
    /// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
    /// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
    Nullable<System.Int16> UnitsOnOrder { get; set; }

    /// <summary> Gets the EntityCollection with the related entities of type 'OrderDetailEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
    [TypeContained(typeof (OrderDetailEntity))]
    EntityCollection<OrderDetailEntity> OrderDetails { get; }

    /// <summary> Gets / sets related entity of type 'CategoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
    [Browsable(false)]
    CategoryEntity Category { get; set; }

    /// <summary> Gets / sets related entity of type 'SupplierEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
    [Browsable(false)]
    SupplierEntity Supplier { get; set; }
  }
}