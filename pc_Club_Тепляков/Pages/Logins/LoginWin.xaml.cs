using pc_Club_Тепляков.Classes;
using pc_Club_Тепляков.Models;
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

namespace pc_Club_Тепляков.Pages.Logins
{
    /// <summary>
    /// Логика взаимодействия для LoginWin.xaml
    /// </summary>
    public partial class LoginWin : Page
    {
        LoginContext AllLogins = new LoginContext();
        public static bool IsAdmin = false;
        public static int ClientLogin;
        public LoginWin()
        {
            InitializeComponent();
            MainWindow.init.AllButtons.Visibility = Visibility.Hidden;
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            if (User.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (Password.Password == "")
            {
                MessageBox.Show($"{User.Text}, введите ваш пароль!");
                return;
            }
            bool userFound = false;
            foreach (Models.Login logins in AllLogins.Logins)
            {
                if (User.Text == logins.User)
                {
                    userFound = true;
                    if (Password.Password == logins.Password)
                    {
                        if (logins.Role == "client")
                            IsAdmin = false;
                        else if (logins.Role == "admin")
                            IsAdmin = true;
                        ClientLogin = logins.Id;
                        MainWindow.init.AllButtons.Visibility = Visibility.Visible;
                        MainWindow.init.OpenPages(new Pages.Clubs.Main());
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Пароль неверный!\nПопробуйте снова!");
                        return;
                    }
                }
            }
            if (!userFound)
            {
                MessageBox.Show($"Пользователь, под логином {User.Text} не найден!\nПопробуйте снова.");
            }
        }
    }
}
