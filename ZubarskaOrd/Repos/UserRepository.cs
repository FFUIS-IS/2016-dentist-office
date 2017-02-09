using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ZubarskaOrd.Models;

namespace ZubarskaOrd.Repos
{
    class UserRepository
    {

        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public static bool Login(User user)
        {
            string sql = "SELECT * FROM [LoginFormTable] WHERE [username] ='" + user.Username + "' AND [password] ='" + user.Password + "'";
            SqlCeCommand command = new SqlCeCommand(sql, connection);
            SqlCeDataAdapter da = new SqlCeDataAdapter(command);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            command.Prepare();
            SqlCeDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetInt32(4) != 0)
                    User.IsAdminUser = true;
                else
                    User.IsAdminUser = false;
            }
            if (user.Username.Length == 0)
                throw new Exception("Username must be entered!");
            else if (user.Password.Length == 0)
                throw new Exception("Password must be entered!");
            else if (dt.Rows.Count == 0)
                throw new Exception("Invalid Login please check username and password");
            

            

            return reader.Read();
           
        }

        public static void Register(User user)
        {
            string sql = "INSERT INTO LoginFormTable(username, password) VALUES ('" + user.Username + "', '" + hashPassword(user.Password) + "')";
            SqlCeCommand command = new SqlCeCommand(sql, connection);
            command.ExecuteReader();
        }

        private static string hashPassword(string password)
        {
            SHA256Managed sha256 = new SHA256Managed();

            byte[] passwordInBytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(passwordInBytes);

            return Convert.ToBase64String(hash);
        }
    }
}

