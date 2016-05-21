using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Fixed.Workflow.Controller;
using Fixed.Workflow.Domain.Entity.Workday;

namespace Fixed.Workflow.View
{
    /// <summary>
    /// Interaction logic for SettlementSpreadSheetWindow.xaml
    /// </summary>
    public partial class SettlementSpreadSheetWindow : Window
    {
        public Workday CurrentWorkday { get; set; }
        public SettlementController SettlementController { get; set; }

        public SettlementSpreadSheetWindow()
        {
            InitializeComponent();
        }

        private void SettlementSpreadSheetWindow_OnClosing(object sender, CancelEventArgs e)
        {
            SettlementController.OnClose();
        }
    }
}
