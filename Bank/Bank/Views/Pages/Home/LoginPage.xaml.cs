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

namespace Bank.Views.Pages.Home
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnChancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var CurrentUser = ConnectContext.db.SignIn.FirstOrDefault(item => item.Username == TxbUsername.Text && item.Password == PsbPassword.Password);
                if (CurrentUser != null)
                {

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
