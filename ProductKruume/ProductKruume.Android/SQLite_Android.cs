using ProductKruume.Droid;
using Xamarin.Forms;
using System.IO;
using Environment = System.Environment;

[assembly: Dependency(typeof(SQLite_Android))]

namespace ProductKruume.Droid
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