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
    /// Interaction logic for ChangeGoal.xaml
    /// </summary>
    public partial class ChangeGoal : Page
    {
        public ChangeGoal()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow) Application.Current.MainWindow;
            if (Check.CheckGoal(mainWindow.user, CheckData.ChengeDot(ValueTextBox.Text)))
            {
                MessageBoxResult result = MessageBox.Show("Changed");
                if (NavigationService.CanGoBack)
                {
                    NavigationService.GoBack();
                    TypeList.RefreshMainView();
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

        private void ValueTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !CheckData.onlyNumeric(e.Text);
        }
    }
}
