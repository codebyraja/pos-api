using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Services.DBContext
{
    public partial class UserAttachDt
    {
        public int SrNo { get; set; }
        public string? Name { get; set; }
        public string? Base64 { get; set; }
        public string? FileName { get; set; }
        public string? FileExt { get; set; }
        public int FileSize { get; set; }
    };

    public partial class SaveUserMast
    {
        public int UserId { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Username { get; set; }
        public string? Pwd { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public int Active { get; set; }
        public int Role { get; set; }
        public int Doc { get; set; }

        [NotMapped]
        public UserAttachDt UserImg { get; set; }

    }

    public partial class LoadUserMast
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Username { get; set; }
        public string? Pwd { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public int Active { get; set; }
        public int Role { get; set; }
        public int Doc { get; set; }
        public int SrNo { get; set; }
        public string? IName { get; set; }
        public string? Image { get; set; }
        public string? FileName { get; set; }
        public string? FileExt { get; set; }
        public double FileSize { get; set; }
    }

    //public class UserDetail
    //{
    //    public int Status { get; set; }
    //    public string MSG { get; set; }
    //    public int UserID { get; set; }
    //    public int UserType { get; set; }
    //    public int DCode { get; set; }
    //    public string DName { get; set; }
    //    public int Admin { get; set; }
    //    public string Name { get; set; }
    //    public string EMail { get; set; }
    //    public string Mobile { get; set; }
    //    public int Active { get; set; }
    //    public string Token { get; set; }
    //}
}
