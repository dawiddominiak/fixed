using System;
using Fixed.Workflow.Domain.Entity.Workday;
using Fixed.Workflow.View;

namespace Fixed.Workflow.Controller
{
    public class WorkdayController
    {
        public MainWindow MainWindow { get; set; }

        public IWorkdayService WorkdayService { get; private set; }
        public SettlementController SettlementController { get; set; }

        public WorkdayController(IWorkdayService workdayService, SettlementController settlementController)
        {
            WorkdayService = workdayService;
            SettlementController = settlementController;
            SettlementController.WorkdayController = this;
        }

        public void Show()
        {
            MainWindow.Show();
        }

        public void Manage(DateTime date)
        {
            var workday = WorkdayService.EnsureWorkday(date);
            SettlementController.OpenSettlement(workday);
            MainWindow.Hide();
        }
    }
}
