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
    /// Логика взаимодействия для DoctorPage.xaml
    /// </summary>
    public partial class DoctorPage : Page
    {
        public DoctorPage()
        {
            InitializeComponent();
        }

        public void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
           
            DataGrid.ItemsSource = ModelConnect.db.User.Where(item => item.RoleID == "P").ToList();

        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataGrid.ItemsSource = ModelConnect.db.User.Where(Item => Item.FirstName == SearchBox.Text || Item.Surname == SearchBox.Text || Item.MKB.DiagnosisNames == SearchBox.Text).ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = (User)DataGrid.SelectedItem;
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы уверены?", 
                    "!!!", 
                    MessageBoxButton.YesNo, 
                    MessageBoxImage.Warning);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    ModelConnect.db.User.Remove(user);
                    ModelConnect.db.SaveChanges();
                    Page_Loaded(null, null);
                }
                else
                {
                    MessageBox.Show("Вы не выбрали элемент", "Hospital", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Возникло исключение", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            User edit1 = (User)DataGrid.SelectedItem;
            if (edit1 != null)
            {
            NavigationService.Navigate(new EditPage(edit1));

            }
        }
    }
}
