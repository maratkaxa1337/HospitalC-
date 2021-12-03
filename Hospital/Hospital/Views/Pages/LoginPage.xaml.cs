using Hospital.Class;
using Hospital.ModelBD;
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

namespace Hospital.Views.Pages
    
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

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        
        public void SignBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            var currentUser = ModelConnect.db.User.FirstOrDefault(item => item.Login == LoginBox.Text &&
            item.Password == PasswordBox.Password);
                if (currentUser != null)
                {

                    switch (currentUser.RoleID)
                    {
                        case "A":
                            MessageBox.Show("Здраствуйте Администратор : " + currentUser.FirstName, 
                                "Приятной Работы", MessageBoxButton.OK, MessageBoxImage.Information);
                            NavigationService.Navigate(new AdminPage());
                            break;
                        case "B":
                            MessageBox.Show("Здраствуйте " +
                                (currentUser.FirstName + " " +  currentUser.Patronymic),"Приятной Работы", MessageBoxButton.OK,
                                MessageBoxImage.Information);
                            NavigationService.Navigate(new DoctorPage());
                            break;
                        case "P":
                            MessageBox.Show("Добро пожаловать " + currentUser.FirstName ,
                                "Hospital", MessageBoxButton.OK, MessageBoxImage.Information);
                            NavigationService.Navigate(new PatientPage());
                            break;
                            
                    }

                    
                    
        
                }
                
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль", "Hospital", MessageBoxButton.OK, MessageBoxImage.Warning);

                }

            }
            catch (Exception)
            {

                
            }
            

        }
    }
}
