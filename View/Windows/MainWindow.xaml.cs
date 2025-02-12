using BookMaster.View.Pages;
using BookMaster.View.Windows;
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

namespace BookMaster
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            LogoutMi.Visibility=Visibility.Collapsed;

            Library.Visibility = Visibility.Visible;
        }
        private void LoginMi_Click(object sender, RoutedEventArgs e)
        {
            // Для реализации оконной навигации нужно:
            // 1) Создать экземпляр окна, которое требует открыть

            LoginWindow loginWindow = new LoginWindow();

            // 2) У экземпляра окна вызвать метод Show() или ShowDialog()
            loginWindow.ShowDialog();


        }
        private void CloseMi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BrowseCatalog_Click(object sender, RoutedEventArgs e)
        {
            // Для ревлизации навигации нужно:
            // 1) Обратиться к элементу Frame по имени и вызываем метод Navigation()
            // 2) В качестве аргумента передаём в метод экземпляр страницы, которую нужно открыть

            MainFrame.Navigate(new BrowseCatalog());
        }
        private void LooutMi_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Loout());
        }

       private void LibraryWatchMi_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LibraryWatch());
        }
       private void ManageCustomersMi(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ManageCustomers());
        }
    }
}
