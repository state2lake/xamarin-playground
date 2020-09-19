using System;
using System.IO;
using Xamarin.Forms;

namespace Playground
{
    public class Constants
    {
        public static string RestUrl = Device.RuntimePlatform == Device.Android ? "https://10.0.2.2:5001/api/todoitems/{0}" : "https://localhost:5001/api/todoitems/{0}";

        public const string DatabaseFilename = "TodoSQLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }


    }
}
