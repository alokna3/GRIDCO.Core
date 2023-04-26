using System;
using System.Collections.Generic;
using System.Text;

namespace GRIDCO.Core.Model
{
   public class AdminModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string ContactNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public int Role { get; set; }
        public int District { get; set; }

        public string Rolename { get; set; }

        public string Districtname { get; set; }

        public int DistrictId { get; set; }


        public int Usertype { get; set; }
    }
}
