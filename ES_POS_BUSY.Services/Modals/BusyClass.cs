using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace ES_POS_BUSY.Services.DBContext
{
    public partial class Response
    {
        public int Status { get; set; }
        public string Msg { get; set; }
    }
    public partial class ImportProduct
    {
        public int Code { get; set; }
        public string? Name { get; set; }
        public string? Sku { get; set; }
        public int CCode { get; set; }
        public string? CName { get; set; }
        public int SCode { get; set; }
        public string? SName { get; set; }
        public int BCode { get; set; }
        public string? BName { get; set; }
        public int UCode { get; set; }
        public string? UName { get; set; }
        public int TCode { get; set; }
        public string? TName { get; set; }
        public int DCode { get; set; }
        public string? DName { get; set; }
        public double MinQty { get; set; }
        public double Qty { get; set; }
        public double Price { get; set; }
        public string? Desc { get; set;}
        public bool IsActive { get; set; }
    }
    public partial class BusyImportProduct
    {
        [NotMapped]
        public List<ImportProduct> ImportProducts { get; set; }
    }
    public partial class CustomerDetails
    {
        public int Code { get; set; }
        public string? Name { get; set; }

    }
}