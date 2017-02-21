using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZubarskaOrd
{
    class CheckUniqueUsername
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public static bool CheckUnique(string UserName)
        {
            bool flag = false;
            
                SqlCeCommand command = new SqlCeCommand("SELECT username FROM LoginFormTable WHERE '" + UserName +"' = username;" , connection);
                SqlCeDataReader reader = command.ExecuteReader();
                if (reader.Read() && reader["username"].ToString() == UserName)
                {
                    flag = true;
                }

            
            return flag;
        }
    }
}
