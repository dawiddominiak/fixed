using System;
using System.Windows;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Fixed.Workflow.Controller;
using Fixed.Workflow.Domain.Repository;
using Fixed.Workflow.Domain.Service;

namespace Fixed.Workflow.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WorkdayController WorkdayController { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ManageButton_Click(object sender, RoutedEventArgs e)
        {
            var module = new WorkflowModule();
            var container = module.Initialize();
            var workdayController = container.Resolve<WorkdayController>();
            WorkdayController = workdayController;

            var selectedDateTime = SelectOperationDateDatePicker.SelectedDate ?? new DateTime();
            WorkdayController.Manage(selectedDateTime);
        }
    }
}
