using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Test.Services.DBContext
{
    public partial class Response
    {
        public int Status { get; set; }
        public string Msg { get; set; }
    }
    public partial class LoadList
    {
        public int id { get; set; }
        public string? Name { get; set; }
    }
    public partial class ProductAttachDt
    {
        public int SrNo { get; set; }
        public string? Name { get; set; }
        public string? Base64 { get; set; }
        public string? FileName { get; set; }
        public string? FileExt { get; set; }
        public int FileSize {  get; set; }
    };
    public partial class SubProductMast
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public int ParentGrp { get; set; }
        public string? Desc { get; set; }
        public string? Users { get; set; }
        public int Doc { get; set; } 
        [NotMapped]
        public ProductAttachDt ProductImages { get; set; }
    }
    public partial class LoadSubProductMast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Alias { get; set; }
        public int PCode { get; set; }
        public string? PName { get; set; }
        public string? Desc { get; set; }
        public int Doc { get; set; }
        public int SrNo { get; set; }
        public string? IName { get; set; }
        public string? Image { get; set; }
        public string? FileName { get; set; }
        public string? FileExt { get; set; }
        public double FileSize { get; set; }
        public string? Users { get; set; }
    }
    public partial class ProductMast
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Category { get; set; }
        public int SubCategory { get; set; }
        public int Brand { get; set; }
        public int Unit { get; set; }
        public string? SKU { get; set; }
        public double MinQty { get; set; }
        public double Qty { get; set; }
        public double Price { get; set; }
        public string? Desc { get; set; }
        public int Tax { get; set; }
        public int DiscType { get; set; }
        public int Status { get; set; }
        public int Doc { get; set; }
        public string? Users { get; set; }

        [NotMapped]
        public ProductAttachDt ProductImages { get; set; }
    }
    public partial class LoadProductMast
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int PC1 { get; set; }
        public string? Cat { get; set; }
        public int PC2 { get; set; }
        public string? SubCat { get; set; }
        public int PC3 { get; set; }
        public string? Brand { get; set; }
        public int PC4 { get; set; }
        public string? Unit { get; set; }
        public string? SKU { get; set; }
        public double MinQty { get; set; }
        public double Qty { get; set; }
        public string? Desc { get; set; }
        public int PC5 { get; set; }
        public string? Tax { get; set; }
        public int PC6 { get; set; }
        public string? DiscType { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }
        public int Doc { get; set; }
        public int SrNo { get; set; }
        public string? IName { get; set; }
        public string? Images { get; set; }
        public string? FileName { get; set; }
        public string? FileExt { get; set; }
        public double FileSize { get; set; }
        public string? Users { get; set; }
    }
    public partial class ProductBrand
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? City { get; set; }
    }
    public partial class ProductSubcategory
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? City { get; set; }

    }
    public partial class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? City { get; set; }
    }
    public partial class AddressMast
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set;}
        public int ParentGrp { get; set; }
        public int SubParentGrp { get; set; }
        public string? Desc { get; set; }
        public string? Users { get; set; }
    }
    public partial class LoadAddressMast
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set;}
        public int CCode { get; set; }
        public string? CName { get; set; }
        public int SCode { get; set; }
        public string? SName { get; set; }
        public string? Desc { get; set; }
        public string? Users { get; set; }

    }
    public partial class GeneratSetting
    {
        public string? Name { get; set; }
        public int TimeZone { get; set; }
        public int Currency { get; set; }
        public int DateFormat { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Address { get; set; }
    }

}

