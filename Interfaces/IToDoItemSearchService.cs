using System;
using System.Collections.Generic;
using System.Text;
using GRIDCO.Core.ProjectAggregate;
using Ardalis.Result;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GRIDCO.Core.Interfaces
{
  public  interface IToDoItemSearchService
    {
        Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
        Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
    }
}
