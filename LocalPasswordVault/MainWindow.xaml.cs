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
using LocalPasswordVault.Models;

namespace LocalPasswordVault
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private VaultData _vault = new VaultData();

        public MainWindow()
        {
            InitializeComponent();

            CreateTestData();

            EntriesList.ItemsSource = _vault.Entries;
        }

        private void CreateTestData()
        {
            PasswordEntry github = new PasswordEntry
            {
                Title = "GitHub",
                Username = "me@example.com",
                Url = "https://github.com"
            };

            github.Versions.Add(new PasswordVersion
            {
                VersionNumber = 1,
                Password = "old123",
                CreatedAt = DateTime.Now.AddDays(-10),
                Comment = "Первый пароль"
            });

            github.Versions.Add(new PasswordVersion
            {
                VersionNumber = 2,
                Password = "new456",
                CreatedAt = DateTime.Now,
                Comment = "Новый пароль"
            });

            PasswordEntry google = new PasswordEntry
            {
                Title = "Google",
                Username = "me@gmail.com",
                Url = "https://google.com"
            };

            google.Versions.Add(new PasswordVersion
            {
                VersionNumber = 1,
                Password = "google-test-password",
                CreatedAt = DateTime.Now,
                Comment = "Тестовая версия"
            });

            _vault.Entries.Add(github);
            _vault.Entries.Add(google);
        }

        private void AddEntryButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Тут позже будет окно добавления новой записи.");
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Тут позже будет сохранение в файл.");
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Тут позже будет загрузка из файла.");
        }

        private void EditEntryButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is TestPasswordEntry entry)
            {
                MessageBox.Show($"Изменить запись: {entry.Title}");
            }
        }

        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is TestPasswordEntry entry)
            {
                MessageBox.Show($"Показать историю для: {entry.Title}");
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Поиск добавим позже.
        }
    }

    public class TestPasswordEntry
    {
        public string Title { get; set; } = "";
    }
}
