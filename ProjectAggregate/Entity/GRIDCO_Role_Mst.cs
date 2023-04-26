using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using GRIDCO.SharedKernel.Interfaces;

namespace GRIDCO.Core.ProjectAggregate.Entity
{
   public  class GRIDCO_Role_Mst : IAggregateRoot
    {
        [Key]
        public int User_Type_Id { get; set; }
        public string User_Type { get; set; }
        public string Created_By { get; set; }
        public DateTime? Created_On { get; set; }
        public string Modified_By { get; set; }
        public DateTime? Modified_On { get; set; }
        public bool? Is_Active { get; set; }
        public bool? Is_Deleted { get; set; }
    }
}
