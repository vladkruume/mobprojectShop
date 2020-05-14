using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace ProductKruume
{
    public class KorzinaRepository
    {
        SQLiteConnection database;
        static object locker = new object();
        public KorzinaRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);//Получение базы данных
            database = new SQLiteConnection(databasePath);//подключаемся к бд
            database.CreateTable<KorzinaTable>();//создаем таблицу
        }
        public IEnumerable<KorzinaTable> GetItems()
        {
            return (from i in database.Table<KorzinaTable>() select i).ToList();
        }
        public KorzinaTable GetItem(int id)
        {
            return database.Get<KorzinaTable>(id);
        }
        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<KorzinaTable>(id);
            }
        }
        public int SaveItem(KorzinaTable item)
        {

            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }

        }
    }
    }

