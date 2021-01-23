using Bank.Context;
using Bank.Views.Pages.Admin.DataView;
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
            Application.Current.Shutdown();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var CurrentUser = ConnectContext.db.SignIn.FirstOrDefault(item => item.Username == TxbUsername.Text && item.Password == PsbPassword.Password);
                if (CurrentUser != null)
                {

                    switch (CurrentUser.IDRole)
                    {
                        case "A":
                            NavigationService.Navigate(new DataViewPage());
                            break;
                        case "U":
                            MessageBox.Show("Пока тут нету ни чего", "Удачи", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("Введите данные!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source + "выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
