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

namespace WPFKCK.View.Calendar
{
    /// <summary>
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Page
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow) Application.Current.MainWindow;
            if (!string.IsNullOrEmpty(PasswordBox.Password) && !string.IsNullOrEmpty(RePasswordBox.Password))
            {
                if (Check.CheckPassword(mainWindow.user, PasswordBox.Password, RePasswordBox.Password))
                {
                    MessageBoxResult result = MessageBox.Show("Changed");
                    if (NavigationService.CanGoBack)
                    {
                        NavigationService.GoBack();
                        TypeList.RefreshMainView();
                    }
                    else
                    {
                        InfoLabel.Content = "Bad Data";
                    }
                }
                else
                {
                    InfoLabel.Content = "Bad Data";
                }
            }
            else
            {
                InfoLabel.Content = "Bad Data";
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
                TypeList.RefreshMainView();
            }
        }
    }
}
