using System;
using System.Collections.Generic;
using System.Text;
using AW.Data.EntityClasses;

namespace AW.Data.ViewModels
{
  public class TransactionHistoryDto
  {
    public decimal ActualCost { get; set; }
    public DateTime ModifiedDate { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }
    public int ReferenceOrderID { get; set; }
    public int ReferenceOrderLineID { get; set; }
    public DateTime TransactionDate { get; set; }
    public int TransactionID { get; set; }
    public string TransactionType { get; set; }

    public TransactionHistoryDto()
    {
    }

    public TransactionHistoryDto(decimal actualCost, DateTime modifiedDate, int productID, int quantity, int referenceOrderID, int referenceOrderLineID, DateTime transactionDate, int transactionID, string transactionType)
    {
      ActualCost = actualCost;
      ModifiedDate = modifiedDate;
      ProductID = productID;
      Quantity = quantity;
      ReferenceOrderID = referenceOrderID;
      ReferenceOrderLineID = referenceOrderLineID;
      TransactionDate = transactionDate;
      TransactionID = transactionID;
      TransactionType = transactionType;
    }

    public TransactionHistoryDto(TransactionHistoryEntity transactionHistoryEntity)
      : this(transactionHistoryEntity.ActualCost, transactionHistoryEntity.ModifiedDate, transactionHistoryEntity.ProductID, 
      transactionHistoryEntity.Quantity, transactionHistoryEntity.ReferenceOrderID, transactionHistoryEntity.ReferenceOrderLineID, 
      transactionHistoryEntity.TransactionDate, transactionHistoryEntity.TransactionID, transactionHistoryEntity.TransactionType)
    {
    }

    public override string ToString()
    {
      var builder = new StringBuilder();
      builder.Append("{ ActualCost = ");
      builder.Append(ActualCost);
      builder.Append(", ModifiedDate = ");
      builder.Append(ModifiedDate);
      builder.Append(", ProductID = ");
      builder.Append(ProductID);
      builder.Append(", Quantity = ");
      builder.Append(Quantity);
      builder.Append(", ReferenceOrderID = ");
      builder.Append(ReferenceOrderID);
      builder.Append(", ReferenceOrderLineID = ");
      builder.Append(ReferenceOrderLineID);
      builder.Append(", TransactionDate = ");
      builder.Append(TransactionDate);
      builder.Append(", TransactionID = ");
      builder.Append(TransactionID);
      builder.Append(", TransactionType = ");
      builder.Append(TransactionType);
      builder.Append(" }");
      return builder.ToString();
    }

    public override bool Equals(object value)
    {
      var type = value as TransactionHistoryDto;
      return (type != null) && EqualityComparer<decimal>.Default.Equals(type.ActualCost, ActualCost) && EqualityComparer<DateTime>.Default.Equals(type.ModifiedDate, ModifiedDate) && EqualityComparer<int>.Default.Equals(type.ProductID, ProductID) && EqualityComparer<int>.Default.Equals(type.Quantity, Quantity) && EqualityComparer<int>.Default.Equals(type.ReferenceOrderID, ReferenceOrderID) && EqualityComparer<int>.Default.Equals(type.ReferenceOrderLineID, ReferenceOrderLineID) && EqualityComparer<DateTime>.Default.Equals(type.TransactionDate, TransactionDate) && EqualityComparer<int>.Default.Equals(type.TransactionID, TransactionID) && EqualityComparer<string>.Default.Equals(type.TransactionType, TransactionType);
    }

    public override int GetHashCode()
    {
      int num = 0x7a2f0b42;
      num = (-1521134295 * num) + EqualityComparer<decimal>.Default.GetHashCode(ActualCost);
      num = (-1521134295 * num) + EqualityComparer<DateTime>.Default.GetHashCode(ModifiedDate);
      num = (-1521134295 * num) + EqualityComparer<int>.Default.GetHashCode(ProductID);
      num = (-1521134295 * num) + EqualityComparer<int>.Default.GetHashCode(Quantity);
      num = (-1521134295 * num) + EqualityComparer<int>.Default.GetHashCode(ReferenceOrderID);
      num = (-1521134295 * num) + EqualityComparer<int>.Default.GetHashCode(ReferenceOrderLineID);
      num = (-1521134295 * num) + EqualityComparer<DateTime>.Default.GetHashCode(TransactionDate);
      num = (-1521134295 * num) + EqualityComparer<int>.Default.GetHashCode(TransactionID);
      return (-1521134295 * num) + EqualityComparer<string>.Default.GetHashCode(TransactionType);
    }
  }
}