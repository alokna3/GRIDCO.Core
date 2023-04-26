using System;
using System.Collections.Generic;
using System.Text;

namespace GRIDCO.Core.ProjectAggregate.Events
{
  public  class NewItemAddedEvent
    {

        public ToDoItem NewItem { get; set; }
        public Project Project { get; set; }

        public NewItemAddedEvent(Project project,
            ToDoItem newItem)
        {
            Project = project;
            NewItem = newItem;
        }
    }
}
