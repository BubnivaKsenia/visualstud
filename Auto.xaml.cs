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
    /// Логика взаимодействия для Auto.xaml
    /// </summary>
    public partial class Auto : Page
    {
        public Auto()
        {
            InitializeComponent();
        }

        private void Btn_Auto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = MyData.ConnectOdb.conOdb.User.FirstOrDefault(x => x.Login == Txb_Login.Text && x.Password == Psb_Password.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нету!","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                }
                else
                {
                    switch (userObj.IdRole)
                    {
                        case 1: MessageBox.Show("Здраствуйте, Администратор"+"  "+userObj.LastName,"Уведомление",MessageBoxButton.OK,MessageBoxImage.Information);Manager.MainFrame.Navigate(new PageAdmin.PageMenuAdmin()) ; break;
                        case 2: MessageBox.Show("Здраствуйте, Ученик"+"  "+userObj.LastName,"Уведомление",MessageBoxButton.OK,MessageBoxImage.Information); Manager.MainFrame.Navigate(new PageStudent.PageAccountStudent()); break;
                        default: MessageBox.Show("Данные не обнаружены","Уведомление",MessageBoxButton.OK,MessageBoxImage.Warning); break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка","Уведомление",MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }

        private void Btn_Registr_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new CreateAccPage());
        }
    }
}
