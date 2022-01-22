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

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для CreateAccPage.xaml
    /// </summary>
    public partial class CreateAccPage : Page
    {
        public CreateAccPage()
        {
            InitializeComponent();
        }

        private void Btn_CreateAcc_Click(object sender, RoutedEventArgs e)
        {
            if (MyData.ConnectOdb.conOdb.User.Count(x => x.Login == Txb_Login.Text)>0)
            {
                MessageBox.Show("Пользователь с таким логином есть!","Уведомление",MessageBoxButton.OK,MessageBoxImage.Information);
                return;
            }


            switch (CheckPasswordClass.ValidatePassword(Txb_Password.Text))
            {
                case false: break;
            }
            try
            {
                MyData.User userObj = new MyData.User()
                {
                    Login = Txb_Login.Text,
                    FirstName = Txb_Name.Text,
                    LastName = Txb_Name.Text,
                    Password = Txb_Password.Text,
                    IdRole = 2
                };
                MyData.ConnectOdb.conOdb.User.Add(userObj);
                MyData.ConnectOdb.conOdb.SaveChanges();
                MessageBox.Show("Данные успешно добавлены!","Уведомление",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных!","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if(Psb_Password.Password != Txb_Password.Text)
            {
                Btn_CreateAcc.IsEnabled = false;
                Psb_Password.Background = Brushes.LightCoral;
                Psb_Password.BorderBrush = Brushes.Red;
            }
            else
            {
                Btn_CreateAcc.IsEnabled = true;
                Psb_Password.Background = Brushes.LightGreen;
                Psb_Password.BorderBrush = Brushes.Green;
            }
        }
    }
}
