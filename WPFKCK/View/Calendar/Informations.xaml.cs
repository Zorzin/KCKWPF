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
    /// Interaction logic for Informations.xaml
    /// </summary>
    public partial class Informations : Page
    {
        public Informations()
        {
            InitializeComponent();
            SetLabels();
            
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
                TypeList.RefreshMainView();
            }
        }


        private void SetLabels()
        {
            MainWindow mainWindow = (MainWindow) Application.Current.MainWindow;
            UserLabel.Content = mainWindow.user.name;
            GoalLabel.Content = mainWindow.user.goal;
            ScoreLabel.Content = GetFromDB.GetScore(mainWindow.user).ToString();
            SwimLabel.Content = mainWindow.user.swimdivider.ToString();
            BikeLabel.Content = mainWindow.user.bikedivider.ToString();
            NumberLabel.Content = GetFromDB.GetNumberOfActivities(mainWindow.user).ToString();
            LastLabel.Content = GetFromDB.GetLastDate(mainWindow.user);
        }
    }
}
