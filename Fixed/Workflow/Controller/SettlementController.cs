using Fixed.Workflow.Domain.Entity.Workday;
using Fixed.Workflow.View;

namespace Fixed.Workflow.Controller
{
    public class SettlementController
    {
        public WorkdayController WorkdayController { get; set; }
        public SettlementSpreadSheetWindow SettlementSpreadSheetWindow { get; set; }

        public SettlementController()
        {
        }

        public void OpenSettlement(Workday workday)
        {
            var settlementWindow = new SettlementSpreadSheetWindow()
            {
                CurrentWorkday = workday,
                SettlementController = this
            };
            settlementWindow.Show();
            SettlementSpreadSheetWindow = settlementWindow;
        }

        public void OnClose()
        {
            SettlementSpreadSheetWindow = null;
            WorkdayController.Show();
        }
    }
}
