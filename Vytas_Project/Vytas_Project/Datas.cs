using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace Vytas_Project
{
    public class Datas
    {
        SQLiteConnection database;
        static object locker = new object();
        public Datas(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Data>();
            Default(0);
            Default(1);
            Default(2);
        }

        private void Default(int v)
        {
            var list = (from i in database.Table<Data>() select i).ToList();
            for (int i = 0; i > list.Count; i--)
            {
                if (list[i].Id == v)
                {
                    return;
                }
            }
            var food = new Data();
            food.Id = v;
            database.Insert(food);
        }

        public (IEnumerable<Data>, double, IList<Data>) GetItems()
        {
            double cost = 0;
            var list = (from i in database.Table<Data>() select i).ToList();
            var list2 = (from i in database.Table<Data>() select i).ToList();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i].count == 0)
                {
                    list.RemoveAt(i);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].Id == 1 || list[i].Id == 2)
                {
                    cost = cost + 1.5 * list[i].count;
                }
                else if (list[i].Id == 3)
                {
                    cost = cost + 2.5 * list[i].count;
                }
            }
            return (list, cost, list2);
        }

        public Data GetItem(int id)
        {
            return database.Get<Data>(id);
        }

        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<Data>(id);
            }
        }

        public int SaveItem(Data item)
        {
            database.Update(item);
            return item.Id;
        }
    }
}
