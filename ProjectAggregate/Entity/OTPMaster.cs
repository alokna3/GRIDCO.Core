using GRIDCO.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRIDCO.Core.ProjectAggregate.Entity
{
    public class OTPMaster : IAggregateRoot
    {
        [Key]
        public int OTPId { get; set; }
        public int OTP { get; set; }
        public string MobileNo { get; set; }
        public string Event { get; set; }
        public DateTime DateTime { get; set; }
        public int Count { get; set; }
        public bool? IsVerified { get; set; }
        public string EmailId { get; set; }
        public int Attempt { get; set; }
        public DateTime Valid_From { get; set; }
        public DateTime Valid_To { get; set; }
    }
}

