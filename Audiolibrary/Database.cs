using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace Audiolibrary
{
    public class Database
    {
        private readonly string _connectionString;

        // Конструктор класса
        public Database()
        {
            string appFolder = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "Audiolibrary"
            );

            Directory.CreateDirectory(appFolder);

            string dbPath = Path.Combine(
                appFolder,
                "audiolibrary.db"
            );

            _connectionString = $"Data Source={dbPath}";
        }

        // Инициализация базы данных
        public void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = """
                    CREATE TABLE IF NOT EXISTS Books (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Title TEXT NOT NULL,
                        Author TEXT NOT NULL,
                        AudioPath TEXT NOT NULL,
                        CoverPath TEXT,
                        DurationSeconds INTEGER DEFAULT 0,
                        LastPositionSeconds INTEGER DEFAULT 0,
                        IsFavorite INTEGER DEFAULT 0,
                        DateAdded TEXT NOT NULL
                    );
                    """;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
