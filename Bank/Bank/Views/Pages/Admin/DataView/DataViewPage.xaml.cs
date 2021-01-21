using Bank.Context;
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

namespace Bank.Views.Pages.Admin.DataView
{
    /// <summary>
    /// Логика взаимодействия для DataViewPage.xaml
    /// </summary>
    public partial class DataViewPage : Page
    {
        public DataViewPage()
        {
            InitializeComponent();
        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataView.ItemsSource = ConnectContext.db.Passport.ToList();
        }
    }
}
