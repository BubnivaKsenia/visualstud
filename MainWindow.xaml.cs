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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrameGrid.Navigate(new Auto());
            Manager.MainFrame = MainFrameGrid;
            MyData.ConnectOdb.conOdb = new MyData.бд2021Entities();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не куда возврощаться!!");
                
            }
        }
    }
}
