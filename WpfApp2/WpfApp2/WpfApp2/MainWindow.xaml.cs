using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace WpfLoginApp
{
    public partial class MainWindow : Window
    {
        private string filePath = "users.txt";

        public MainWindow()
        {
            InitializeComponent();
            if (!File.Exists(filePath))
                File.Create(filePath).Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text.Trim();
            string password = PasswordBox.Password.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ErrorTextBlock.Text = "Заповніть всі поля!";
                return;
            }

            string userLine = $"{email}:{password}";
            bool userExists = false;

            foreach (var line in File.ReadAllLines(filePath))
            {
                if (line == userLine)
                {
                    userExists = true;
                    break;
                }
            }

            if (!userExists)
            {
                File.AppendAllText(filePath, userLine + Environment.NewLine);
            }

            // Показати панель вітання
            LoginPanel.Visibility = Visibility.Collapsed;
            WelcomePanel.Visibility = Visibility.Visible;
            EmailTextBlock.Text = email;
        }
    }
}
