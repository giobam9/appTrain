using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace apptrain
{
    public class WorkoutEntery
    {
        [PrimaryKey, AutoIncrement]//PrimaryKey -переменная будет первичным ключом таблицы,AutoIncrement — SQLite будет сам увеличивать Id при каждой новой записи
        public int Id {get;set;}
        public string Exercise { get; set; }//название приложений

        public int Podxod { get; set; }//пордходы
        public int Povtor { get; set; }//повторы
        public DateTime Date { get; set; }//дата тренировки
    }
}
