using CustomerList.WPF.ViewModels;
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

namespace CustomerList.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public CustomerListPageViewModel ViewModel { get; set; } = new CustomerListPageViewModel();

        public MainWindow()
        {
            InitializeComponent();

            string versionNumber = string.Empty;

            string file = "Version.txt";

            if (System.IO.File.Exists(file)) {
                versionNumber = System.IO.File.ReadAllText(file);
            }

            txtVersionNumber.Text = $"Version: {versionNumber}";

            DataContext = ViewModel;
            DG1.Items.Refresh();
        }



        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
