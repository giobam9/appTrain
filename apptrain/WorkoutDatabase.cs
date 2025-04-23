using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace apptrain
{
    public class WorkoutDatabase
    {
        readonly SQLiteAsyncConnection _database; //Переменная, через которую мы будем обращаться к SQLite

        public WorkoutDatabase(string dbPath)//dbPath — путь к файлу базы данных
        {
            _database = new SQLiteAsyncConnection(dbPath);//new SQLiteAsyncConnection(...) — создаём подключение к файлу базы
            _database.CreateTableAsync<WorkoutEntery>().Wait();//CreateTableAsync<WorkoutEntry>() — создаёт таблицу, если она ещё не создана
        }
        public Task<int> SaveWorkoutAsync(WorkoutEntery entry)//Метод, чтобы сохранить одну тренировку в таблицу.
        {
            return _database.InsertAsync(entry);//InsertAsync(entry) — добавляет эту строку в таблицу 
        }
        public Task<List<WorkoutEntery>> GetWorkoutsAsync()//метод читает все записи из таблицы
        {
            return _database.Table<WorkoutEntery>().ToListAsync();
        }
    }
}
