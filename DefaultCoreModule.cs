using System;
using System.Collections.Generic;
using System.Text;
using GRIDCO.Core.Services;
using Autofac;
using GRIDCO.Core.ProjectAggregate;
using GRIDCO.Core.Interfaces;

namespace GRIDCO.Core
{
   public class DefaultCoreModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
