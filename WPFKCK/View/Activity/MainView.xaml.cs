using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFKCK.View.Activity
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Page
    {
        private List<Model1.Activity> activities;
        public MainView(List<Model1.Activity> activitiesList)
        {
            InitializeComponent();
            activities = activitiesList;
            ActivityListBox.ItemsSource = activities;
            TypeComboBox.ItemsSource = TypeList.ReturnTypeList();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Model1.Activity activity = (Model1.Activity)ActivityListBox.SelectedItem;
            if (activity != null)
            {
                float distance = float.Parse(CheckData.ChengeDot(DistanceTextBox.Text));
                var type = (string) TypeComboBox.SelectedItem;
                if (SaveDB.Save(activity, DatePicker.SelectedDate, distance, NoteTextBox.Text, type))
                {
                    ActivityListBox.ItemsSource = null;
                    ActivityListBox.ItemsSource = activities;
                    MessageBoxResult result = MessageBox.Show("Edited");
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Something goes wrong");
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Something goes wrong");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Model1.Activity activity = (Model1.Activity)ActivityListBox.SelectedItem;
            if (SaveDB.DeleteActivity(activity, activities))
            {
                ActivityListBox.ItemsSource = null;
                ActivityListBox.ItemsSource = activities;
                MessageBoxResult result = MessageBox.Show("Deleted");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Something goes wrong");
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
