using System;
using System.Collections.Generic;
using System.Text;
using Ardalis.Specification;
namespace GRIDCO.Core.ProjectAggregate.Specifications
{
    public class IncompleteItemsSpec : Specification<ToDoItem>
    {
        public IncompleteItemsSpec()
        {
            Query.Where(item => !item.IsDone);
        }
    }
}
