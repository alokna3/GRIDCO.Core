using System;
using System.Collections.Generic;
using System.Text;
using Ardalis.Specification;

namespace GRIDCO.Core.ProjectAggregate.Specifications
{
   public  class IncompleteItemsSearchSpec: Specification<ToDoItem>
    {
        public IncompleteItemsSearchSpec(string searchString)
        {
            Query
                .Where(item => !item.IsDone &&
                (item.Title.Contains(searchString) ||
                item.Description.Contains(searchString)));
        }
    }
}
