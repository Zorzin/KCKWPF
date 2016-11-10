using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPFKCK.View.Calendar
{
    /// <summary>
    /// Interaction logic for AddActivity.xaml
    /// </summary>
    public partial class AddActivity : Page
    {
        public AddActivity()
        {
            InitializeComponent();
            TypeComboBox.ItemsSource = TypeList.ReturnTypeList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow) Application.Current.MainWindow;
            User user = mainWindow.user;
            string type = (string) TypeComboBox.SelectionBoxItem;
            if (!string.IsNullOrEmpty(DistanceTextBox.Text))
            {
                float distance = float.Parse(CheckData.ChengeDot(DistanceTextBox.Text));
                if (type != null && (DatePicker.SelectedDate != null && SaveDB.AddActivityToDB(user,type,distance,DatePicker.SelectedDate.Value,NoteTextBox.Text)))
                {
                    MessageBoxResult msgBoxResult = MessageBox.Show("Added");
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
        private void DistanceTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !CheckData.onlyNumeric(e.Text);
        }
    }
}
