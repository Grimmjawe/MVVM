using System.IO;
using System;
using Xamarin.Forms;
using Vytas_Project.Droid;

[assembly: Dependency(typeof(SQLite_Android))]
namespace Vytas_Project.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }
    }
}