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
using WPFKCK.Data;
using WPFKCK.Logic;
using WPFKCK.Model1;

namespace WPFKCK.View.MainView
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            User user = CheckData.Login(NameTextBox.Text, PasswordTextBox.Password);
            if (user == null)
            {
                InfoLabel.Content = "Bad Data";
            }
            else
            {
                MainWindow mainWindow = (MainWindow) Application.Current.MainWindow;
                mainWindow.user = user;
                Calendar.MainView mainView = new Calendar.MainView();
                mainWindow.MainView = mainView;
                TypeList.RefreshMainView();
                mainWindow.Frame.Navigate(mainView);
            }
            
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
