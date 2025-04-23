using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using apptrain;

namespace apptrain
{
    public partial class App : Application
    {
        // 🔹 Статическое свойство для доступа к базе из любого места
        public static WorkoutDatabase Database { get; private set; }

        public App()
        {
            InitializeComponent();

            // 🔹 Путь к файлу базы данных
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "workouts.db3");

            // 🔹 Инициализация базы
            Database = new WorkoutDatabase(dbPath);

            // 🔹 Загрузка первой страницы
            MainPage = new NavigationPage(new MainPage());
        }
    }
}