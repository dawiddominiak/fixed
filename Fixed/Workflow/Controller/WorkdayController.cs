using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixed.Workflow.Domain;
using Fixed.Workflow.Domain.Repository;
using Fixed.Workflow.Domain.Service;

namespace Fixed.Workflow.Controller
{
    public class WorkdayController
    {
        public WorkdayRepository WorkdayRepository { get; private set; }
        public WorkdayService WorkdayService { get; private set; }

        public WorkdayController(WorkdayService workdayService)
        {
            WorkdayService = workdayService;
        }

        public void Manage(DateTime date)
        {
            var workday = WorkdayService.FindOneByDate(date);
        }
    }
}
