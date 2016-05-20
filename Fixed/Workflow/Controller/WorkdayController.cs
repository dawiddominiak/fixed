using System;
using Fixed.Workflow.Domain.Entity.Workday;

namespace Fixed.Workflow.Controller
{
    public class WorkdayController
    {
        public IWorkdayRepository WorkdayRepository { get; private set; }
        public IWorkdayService WorkdayService { get; private set; }

        public WorkdayController(IWorkdayService workdayService)
        {
            WorkdayService = workdayService;
        }

        public void Manage(DateTime date)
        {
            var workday = WorkdayService.FindOneByDate(date);
        }
    }
}
