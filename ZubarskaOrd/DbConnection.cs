using System;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;

namespace ZubarskaOrd
{
    class DbConnection
    {
        private static DbConnection instance;

        private SqlCeConnection connection;

        private DbConnection()
        {
            string connectionString = "Data Source=" + Program.path + "Database.sdf; Password=database32";
            connection = new SqlCeConnection(connectionString);
            try { connection.Open();  }
            catch (Exception e)
            { MessageBox.Show(e.ToString()); };

        }

        public static DbConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new DbConnection();

                return instance;
            }
        }

        public SqlCeConnection Connection
        {
            get
            {
                return connection;
            }
        }
    }
}
