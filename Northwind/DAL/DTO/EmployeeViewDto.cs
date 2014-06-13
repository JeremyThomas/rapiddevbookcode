using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.DAL.EntityClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace Northwind.DAL.DTO
{
  public class EmployeeViewDto
  {
    private EmployeeViewDto(string address, DateTime? birthDate, string city, string country, int employeeId, string extension, 
      string firstName, DateTime? hireDate, string homePhone, string lastName, string notes, byte[] photo, string photoPath, 
      string postalCode, string region, int? reportsTo, string title, string titleOfCourtesy)
    {
      Address = address;
      BirthDate = birthDate;
      City = city;
      Country = country;
      EmployeeId = employeeId;
      Extension = extension;
      FirstName = firstName;
      HireDate = hireDate;
      HomePhone = homePhone;
      LastName = lastName;
      Notes = notes;
      Photo = photo;
      PhotoPath = photoPath;
      PostalCode = postalCode;
      Region = region;
      ReportsTo = reportsTo;
      Title = title;
      TitleOfCourtesy = titleOfCourtesy;
    }

    private EmployeeViewDto()
    {

    }

    private EmployeeViewDto(EmployeeEntity e)
      : this(e.Address,
        e.BirthDate,
        e.City,
        e.Country,
        e.EmployeeId,
        e.Extension,
        e.FirstName,
        e.HireDate,
        e.HomePhone,
        e.LastName,
        e.Notes,
        e.Photo,
        e.PhotoPath,
        e.PostalCode,
        e.Region,
        e.ReportsTo,
        e.Title,
        e.TitleOfCourtesy)
    {
  
    }

    public string Address { get; set; }
    public DateTime? BirthDate { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public int EmployeeId { get; set; }
    public string Extension { get; set; }
    public string FirstName { get; set; }
    public DateTime? HireDate { get; set; }
    public string HomePhone { get; set; }
    public string LastName { get; set; }
    public string Notes { get; set; }
    public byte[] Photo { get; set; }
    public string PhotoPath { get; set; }
    public string PostalCode { get; set; }
    public string Region { get; set; }
    public int? ReportsTo { get; set; }
    public string Title { get; set; }
    public string TitleOfCourtesy { get; set; }

    public override string ToString()
    {
      var builder = new StringBuilder();
      builder.Append("{ Address = ");
      builder.Append(Address);
      builder.Append(", BirthDate = ");
      builder.Append(BirthDate);
      builder.Append(", City = ");
      builder.Append(City);
      builder.Append(", Country = ");
      builder.Append(Country);
      builder.Append(", EmployeeId = ");
      builder.Append(EmployeeId);
      builder.Append(", Extension = ");
      builder.Append(Extension);
      builder.Append(", FirstName = ");
      builder.Append(FirstName);
      builder.Append(", HireDate = ");
      builder.Append(HireDate);
      builder.Append(", HomePhone = ");
      builder.Append(HomePhone);
      builder.Append(", LastName = ");
      builder.Append(LastName);
      builder.Append(", Notes = ");
      builder.Append(Notes);
      builder.Append(", Photo = ");
      builder.Append(Photo);
      builder.Append(", PhotoPath = ");
      builder.Append(PhotoPath);
      builder.Append(", PostalCode = ");
      builder.Append(PostalCode);
      builder.Append(", Region = ");
      builder.Append(Region);
      builder.Append(", ReportsTo = ");
      builder.Append(ReportsTo);
      builder.Append(", Title = ");
      builder.Append(Title);
      builder.Append(", TitleOfCourtesy = ");
      builder.Append(TitleOfCourtesy);
      builder.Append(" }");
      return builder.ToString();
    }

    public override bool Equals(object value)
    {
      var type = value as EmployeeViewDto;
      return (type != null) && EqualityComparer<string>.Default.Equals(type.Address, Address) && EqualityComparer<DateTime?>.Default.Equals(type.BirthDate, BirthDate) && EqualityComparer<string>.Default.Equals(type.City, City) && EqualityComparer<string>.Default.Equals(type.Country, Country) && EqualityComparer<int>.Default.Equals(type.EmployeeId, EmployeeId) && EqualityComparer<string>.Default.Equals(type.Extension, Extension) && EqualityComparer<string>.Default.Equals(type.FirstName, FirstName) && EqualityComparer<DateTime?>.Default.Equals(type.HireDate, HireDate) && EqualityComparer<string>.Default.Equals(type.HomePhone, HomePhone) && EqualityComparer<string>.Default.Equals(type.LastName, LastName) && EqualityComparer<string>.Default.Equals(type.Notes, Notes) && EqualityComparer<byte[]>.Default.Equals(type.Photo, Photo) && EqualityComparer<string>.Default.Equals(type.PhotoPath, PhotoPath) && EqualityComparer<string>.Default.Equals(type.PostalCode, PostalCode) && EqualityComparer<string>.Default.Equals(type.Region, Region) && EqualityComparer<int?>.Default.Equals(type.ReportsTo, ReportsTo) && EqualityComparer<string>.Default.Equals(type.Title, Title) && EqualityComparer<string>.Default.Equals(type.TitleOfCourtesy, TitleOfCourtesy);
    }

    public override int GetHashCode()
    {
      int num = 0x7a2f0b42;
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Address);
      num = (-1521134295*num) + EqualityComparer<DateTime?>.Default.GetHashCode(BirthDate);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(City);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Country);
      num = (-1521134295*num) + EqualityComparer<int>.Default.GetHashCode(EmployeeId);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Extension);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(FirstName);
      num = (-1521134295*num) + EqualityComparer<DateTime?>.Default.GetHashCode(HireDate);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(HomePhone);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(LastName);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Notes);
      num = (-1521134295*num) + EqualityComparer<byte[]>.Default.GetHashCode(Photo);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(PhotoPath);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(PostalCode);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Region);
      num = (-1521134295*num) + EqualityComparer<int?>.Default.GetHashCode(ReportsTo);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Title);
      return (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(TitleOfCourtesy);
    }

    public static IQueryable<EmployeeViewDto> EmployeeViewDtoFactoryPropertyProjection(IQueryable<EmployeeEntity> employeeEntities)
    {
      return from e in employeeEntities
             select new EmployeeViewDto
               {
                 Address = e.Address,
                 BirthDate = e.BirthDate,
                 City = e.City,
                 Country = e.Country,
                 EmployeeId = e.EmployeeId,
                 Extension = e.Extension,
                 FirstName = e.FirstName,
                 HireDate = e.HireDate,
                 HomePhone = e.HomePhone,
                 LastName = e.LastName,
                 Notes = e.Notes,
                 Photo = e.Photo,
                 PhotoPath = e.PhotoPath,
                 PostalCode = e.PostalCode,
                 Region = e.Region,
                 ReportsTo = e.ReportsTo,
                 Title = e.Title,
                 TitleOfCourtesy = e.TitleOfCourtesy
               };
    }

    public static IQueryable<EmployeeViewDto> EmployeeViewDtoFactoryPropertiesViaConstructor(IQueryable<EmployeeEntity> employeeEntities)
    {
      return from e in employeeEntities
             select new EmployeeViewDto
             (
                e.Address,
                e.BirthDate,
                e.City,
                e.Country,
                e.EmployeeId,
                e.Extension,
                e.FirstName,
                e.HireDate,
                e.HomePhone,
                e.LastName,
                e.Notes,
                e.Photo,
                e.PhotoPath,
                e.PostalCode,
                e.Region,
                e.ReportsTo,
                e.Title,
                e.TitleOfCourtesy
             );
    }

    public static IQueryable<EmployeeViewDto> EmployeeViewDtoFactoryEntityInstance(IQueryable<EmployeeEntity> employeeEntities)
    {
      return from e in employeeEntities select new EmployeeViewDto(e);
    }
  }

}