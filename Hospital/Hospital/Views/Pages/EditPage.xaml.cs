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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private User selecteditem;
        
        public EditPage(User selecteditem)
        {
            InitializeComponent();
            this.selecteditem = selecteditem;
            TxbAddress.Text = selecteditem.HomeAddress;
            TxbFirsname.Text = selecteditem.FirstName;
            TxbLogin.Text = selecteditem.Login;
            TxbPassword.Text = selecteditem.Password;
            TxbPatronymic.Text = selecteditem.Patronymic;
            TxbSurname.Text = selecteditem.Surname;
            CmbGender.SelectedItem = selecteditem.GenderID;
            CmbMKB.SelectedItem = selecteditem.MKB.DiagnosisNames;
            DateEnd.SelectedDate = selecteditem.DateStopDiseases;
            DateStart.SelectedDate = selecteditem.DateStartDiseases;
            DateBrith.SelectedDate = selecteditem.BrithDay;
        }

        

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                var CurrentLogin = ModelConnect.db.User.FirstOrDefault(item => item.Login == TxbLogin.Text);
                if (CurrentLogin == null)
                {

                    User user = new User()
                    {
                        FirstName = TxbFirsname.Text,
                        Surname = TxbSurname.Text,
                        Patronymic = TxbPatronymic.Text,
                        Login = TxbLogin.Text,
                        Password = TxbPassword.Text,
                        HomeAddress = TxbAddress.Text,
                        MKB = CmbMKB.SelectedItem as MKB,
                        Gender = CmbGender.SelectedItem as Gender,
                        DateStartDiseases = DateStart.SelectedDate.Value,
                        DateStopDiseases = DateEnd.SelectedDate.Value,
                        BrithDay = DateBrith.SelectedDate.Value,
                        RoleID = "P",
                        CodeID = 367029


                    };
                    ModelConnect.db.User.Add(user);
                    ModelConnect.db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены");
                }
                else
                {
                    MessageBox.Show("Логин уже используется", "Систем", MessageBoxButton.OK, MessageBoxImage.Information);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        

    private void BtnBack2_Click(object sender, RoutedEventArgs e)
    {
        NavigationService.GoBack();

    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CmbGender.ItemsSource = ModelConnect.db.User.Select(item => item.Gender.Title).ToList();
            CmbMKB.ItemsSource = ModelConnect.db.User.Select(Item => Item.MKB.DiagnosisNames).ToList();
        }
    }
}
