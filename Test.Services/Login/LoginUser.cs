using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Services.DBContext
{
    public class UserDetail
    {
        public int UserId { get; set; }
        public int UserType { get; set; }
        public int Admin { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public string Mobile { get; set; }
        public int Active { get; set; }
    }

    public partial class UserValidate
    {
        public int UserId { get; set; }
        public int Usertype { get; set; }
        public int Admin { get; set; }
        public string? Name { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public int Active { get; set; }
        public string? Images { get; set; }
    }
}
