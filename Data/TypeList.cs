using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFKCK.Logic;

namespace WPFKCK.Data
{
    static class TypeList
    {
        public static List<string> ReturnTypeList()
        {
            List<string> typeList = new List<string>() {"run","bike","swim"};
            return typeList;
        }

        public static void RefreshMainView()
        {
            MainWindow mainWindow = (MainWindow) Application.Current.MainWindow;
            mainWindow.MainView.GoalLabel.Content = mainWindow.user.goal;
            mainWindow.MainView.ScoreLabel.Content = GetFromDB.GetScore(mainWindow.user);
        }
    }
}
