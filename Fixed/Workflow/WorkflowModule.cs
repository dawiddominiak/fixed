using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Fixed.Workflow.Controller;
using Fixed.Workflow.Domain.Repository;
using Fixed.Workflow.Domain.Service;
using Component = Castle.MicroKernel.Registration.Component;

namespace Fixed.Workflow
{
    public class WorkflowModule
    {
        public IWindsorContainer Initialize()
        {
            var container = new WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<WorkdayController>());
            container.Register(Castle.MicroKernel.Registration.Component.For<WorkdayService>());
            container.Register(Component.For<WorkdayRepository>());

            return container;
        }
    }
}
