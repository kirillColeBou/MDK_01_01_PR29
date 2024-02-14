using pc_Club_Тепляков.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pc_Club_Тепляков.Pages.Users
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public UserContext AllUsers = new UserContext();
        public Main()
        {
            InitializeComponent();
            foreach (Models.Users User in AllUsers.Users)
                parent.Children.Add(new Elements.Item(User, this));
        }

        private void AddUser(object sender, RoutedEventArgs e) => MainWindow.init.OpenPages(new Pages.Users.Add(this));

        private void ClubMain(object sender, RoutedEventArgs e)
        {

        }

        private void UserMain(object sender, RoutedEventArgs e)
        {

        }
    }
}
