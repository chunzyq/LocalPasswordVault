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

namespace LocalPasswordVault
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Временные тестовые записи, чтобы увидеть дизайн списка.
            EntriesList.ItemsSource = new List<TestPasswordEntry>
        {
            new TestPasswordEntry { Title = "GitHub" },
            new TestPasswordEntry { Title = "Google" },
            new TestPasswordEntry { Title = "Steam" },
            new TestPasswordEntry { Title = "Discord" },
            new TestPasswordEntry { Title = "Facebook" },
            new TestPasswordEntry { Title = "Twitter" },
            new TestPasswordEntry { Title = "LinkedIn" }
        };
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
