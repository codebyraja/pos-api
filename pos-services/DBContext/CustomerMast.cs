using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Services.DBContext
{
    public partial class CustAttachDt
    {
        public int SrNo { get; set; }
        public string? Name { get; set; }
        public string? Base64 { get; set; }
        public string? FileName { get; set; }
        public string? FileExt { get; set; }
        public int FileSize { get; set; }
    };
    public partial class SaveCustomerMast
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Gstin { get; set; }
        public string? Pan { get; set; }
        public int Country { get; set; }
        public int State { get; set; }
        public int City { get; set; }  
        public string? Address { get; set; }
        public string? Desc { get; set; }
        public int Doc { get; set; }

        [NotMapped]
        public CustAttachDt CustImg { get; set; }

    }
    public partial class LoadCustomerMast
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Gstin { get; set; }
        public string? Pan { get; set; }
        public int CRCode { get; set; }
        public string? CRName { get; set; }
        public int STCode { get; set; }
        public string? STName { get; set; }
        public int CTCode { get; set; }
        public string? CTName { get; set; }
        public string? Address { get; set; }
        public string? Desc { get; set; }
        public int Doc { get; set; }
        public int SrNo { get; set; }
        public string? IName { get; set; }
        public string? Image { get; set; }
        public string? FileName { get; set; }
        public string? FileExt { get; set; }
        public double FileSize { get; set; }

    }
}
