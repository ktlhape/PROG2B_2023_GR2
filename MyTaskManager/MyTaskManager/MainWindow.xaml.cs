using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace MyTaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadTasks();
        }

        public void LoadTasks()
        {
            string myPC = Environment.MachineName;

            var allProcesses = from proc in Process.GetProcesses(myPC)
                               orderby proc.ProcessName descending
                               select proc;

            foreach (var p in allProcesses)
            {
                lstDisplay.Items.Add($"{p.Id} {p.ProcessName}");
            }
        }

        private void btnEndTask_Click(object sender, RoutedEventArgs e)
        {
            string selected = lstDisplay.SelectedItem.ToString();
            int spIndex = selected.IndexOf(" ");
            int pID = Convert.ToInt32(selected.Substring(0, spIndex));

            Process proc = Process.GetProcessById(pID);
            proc.Kill();
        }
    }
}
