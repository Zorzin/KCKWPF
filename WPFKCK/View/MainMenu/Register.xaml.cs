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
using System.Windows.Shapes;
using WPFKCK.Logic;

namespace WPFKCK.View.MainMenu
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckData.Register(NameTextBox.Text, PasswordTextBox.Password, RePasswordTextBox.Password, GoalTextBox.Text,
                BikeDividerTextBox.Text, SwimDividerTextBox.Text))
            {
                //popup!!!
                if (NavigationService.CanGoBack)
                {
                    NavigationService.GoBack();
                }
            }
            else
            {
                InfoLabel.Content = "Something goes wrong!";
            }

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void NumericInput_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !CheckData.onlyNumeric(e.Text);
        }
    }
}
