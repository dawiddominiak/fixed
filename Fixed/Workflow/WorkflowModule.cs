using Castle.Windsor;
using Fixed.Workflow.Controller;
using Fixed.Workflow.Domain;
using Fixed.Workflow.Domain.Entity;
using Fixed.Workflow.Domain.Entity.Workday;
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
            container.Register(Component.For<WorkdayController>());
            container.Register(Component.For<SettlementController>());
            container.Register(Component.For<WorkflowContext>());
            container.Register(Component.For<IWorkdayRepository>().ImplementedBy<WorkdayRepository>());
            container.Register(Component.For<IWorkdayService>().ImplementedBy<WorkdayService>());

            return container;
        }
    }
}
