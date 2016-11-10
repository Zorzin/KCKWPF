using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFKCK.View.Calendar
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        private User user;
        public Search()
        {
            var mainWindow = (MainWindow) Application.Current.MainWindow;
            user = mainWindow.user;
            InitializeComponent();
            SearchComboBox.ItemsSource = new List<string>() {"type","distance","date","note"};
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow) Application.Current.MainWindow;
            List<Model1.Activity> activities = null; 
            string comboBoxItem = (string)SearchComboBox.SelectedItem;
            switch (comboBoxItem)
            {
                case "type":
                    string type = (string) TypeComboBox.SelectedItem;
                    if (type!=null)
                    {
                        activities = SearchDB.SearchType(type, user);
                    }
                    else
                    {
                        InfoLabel.Content = "Bad Data";
                    }
                    break;
                case "distance":
                    if (!string.IsNullOrEmpty(DistanceTextBox.Text))
                    {
                        var distance = float.Parse(DistanceTextBox.Text);
                        activities = SearchDB.SearchDistance(distance, user);
                    }
                    else
                    {
                        InfoLabel.Content = "Bad Data";
                    }
                    break;
                case "date":
                    if (DatePicker.SelectedDate != null)
                    {
                        DateTime date = DatePicker.SelectedDate.Value;
                        activities = SearchDB.SearchDate(date, user);
                    }
                    else
                    {
                        InfoLabel.Content = "Bad Data";
                    }
                    break;
                case "note":
                    string note = NoteTextBox.Text;
                    if (!string.IsNullOrEmpty(note))
                    {
                        activities = SearchDB.SearchNote(note, user);
                    }
                    else
                    {
                        InfoLabel.Content = "Bad Data";
                    }
                    break;
            }
            if (activities !=null)
            {
                mainWindow.Frame.Navigate(new View.Activity.MainView(activities));
            }
        }

        private void SearchComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Grid mainGrid = this.BoxGrid;
            string comboBoxItem = (string)SearchComboBox.SelectedItem;
            switch (comboBoxItem)
            {
                case "type":
                    TypeComboBox.ItemsSource = TypeList.ReturnTypeList();
                    DatePicker.Visibility = Visibility.Hidden;
                    DistanceTextBox.Visibility = Visibility.Hidden;
                    NoteTextBox.Visibility = Visibility.Hidden;
                    TypeComboBox.Visibility = Visibility.Visible;
                    break;
                case "date":
                    DistanceTextBox.Visibility = Visibility.Hidden;
                    NoteTextBox.Visibility = Visibility.Hidden;
                    TypeComboBox.Visibility = Visibility.Hidden;
                    DatePicker.Visibility = Visibility.Visible;
                    break;
                case "distance":
                    NoteTextBox.Visibility = Visibility.Hidden;
                    TypeComboBox.Visibility = Visibility.Hidden;
                    DatePicker.Visibility = Visibility.Hidden;
                    DistanceTextBox.Visibility = Visibility.Visible;
                    break;
                case "note":
                    TypeComboBox.Visibility = Visibility.Hidden;
                    DatePicker.Visibility = Visibility.Hidden;
                    DistanceTextBox.Visibility = Visibility.Hidden;
                    NoteTextBox.Visibility = Visibility.Visible;
                    break;
            }
            ValueLabel.Visibility = Visibility.Visible;
            SearchButton.Visibility = Visibility.Visible;
        }

        private void DistanceTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !CheckData.onlyNumeric(e.Text);
        }
    }
}
