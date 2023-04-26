using System;
using System.Collections.Generic;
using System.Text;

namespace GRIDCO.Core.Model
{
   public class ChangePasswordModel
    {
        public int UserId { get; set; }
        public string Oldpassword { get; set; }

        public string Newpassword { get; set; }

        public string ConfirmNewpassword { get; set; }
    }
}
