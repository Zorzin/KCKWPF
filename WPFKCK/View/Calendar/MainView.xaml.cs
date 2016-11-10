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
using WPFKCK.View.MainView;

namespace WPFKCK.View.Calendar
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Page
    {
        private MainWindow mainWindow;
        public MainView()
        {
            mainWindow = (MainWindow) Application.Current.MainWindow;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Frame.Navigate(new AddActivity());
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Frame.Navigate(new Search());
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Frame.Navigate(new Activity.MainView(GetFromDB.LoadList(mainWindow.user)));
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.user = null;
            mainWindow.Frame.Navigate(new Index());
        }

        private void GoalButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Frame.Navigate(new ChangeGoal());
        }

        private void DividersButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Frame.Navigate(new ChangeDivider());
        }

        private void PasswordButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Frame.Navigate(new ChangePassword());
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Frame.Navigate(new Informations());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
