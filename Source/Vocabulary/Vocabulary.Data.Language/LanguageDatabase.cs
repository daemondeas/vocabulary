using System.Collections.Generic;
using System.Linq;

using SQLite;

using Xamarin.Forms;

namespace Vocabulary.Data.Languages
{
    public class LanguageDatabase
    {
        private static SQLiteConnection connection;

        private static LanguageDatabase database;

        public LanguageDatabase(string dbPath)
        {
            connection = new SQLiteConnection(dbPath);
            connection.CreateTable<Language>();
        }

        public static LanguageDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new LanguageDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("LanguageDB.db3"));
                }

                return database;
            }
        }

        public List<Language> GetLanguages()
        {
            return connection.Table<Language>().ToList();
        }
    }
}
