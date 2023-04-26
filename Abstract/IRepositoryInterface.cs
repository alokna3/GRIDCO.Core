using System;
using System.Collections.Generic;
using System.Text;
using GRIDCO.Core.ProjectAggregate.Entity;

namespace GRIDCO.Core.Abstract
{
   public interface IRepositoryInterface
    {
        int SaveRole(GRIDCO_Role_Mst DD);
        bool DeleteRole(int id);
    }
}
