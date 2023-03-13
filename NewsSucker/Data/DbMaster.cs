using SQLite;
using System.Data;

namespace NewsSucker.Data
{
    public class DbMaster
    {
        SQLiteConnection sqlite_conn;
        string path;
       
        public DbMaster()
        {
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "database.db");
            sqlite_conn = new SQLiteConnection(path);
            AddFilter("test");
        }

        public void Seed()
        {
            
        }

        public void AddFilter(string filtername)
        {
            sqlite_conn = new SQLiteConnection(path);
            SQLiteCommand newTable = sqlite_conn.CreateCommand($"CREATE TABLE IF NOT EXISTS {filtername} (Col1 INT Primary Key, Col2 VARCHAR(50))");

            newTable.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public void GetFilters() 
        { 
            List<string> filters = new List<string>();
            sqlite_conn = new SQLiteConnection(path);
            using (sqlite_conn)
            {
                var cmd = sqlite_conn.CreateCommand("SELECT name FROM sqlite_master WHERE type = 'table' ORDER BY 1");
                var test = cmd.ExecuteScalar<string>().ToList();
                sqlite_conn.Close();
            }
        }

        

    }

}
