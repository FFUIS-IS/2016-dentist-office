using System;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Security.Cryptography;
using System.Text;
using ZubarskaOrd.Models;

namespace ZubarskaOrd.Repos
{
    class UserRepository
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;

        public static bool Login(User user)
        {
            string sql = "SELECT * FROM LoginFormTable WHERE username = @username AND password = @password";
            SqlCeCommand command = new SqlCeCommand(sql, connection);
            command.Parameters.Add(new SqlCeParameter("@username", user.Username));
            command.Parameters.Add(new SqlCeParameter("@password", hashPassword(user.Password)));

            command.Prepare();
            SqlCeDataReader reader = command.ExecuteReader();

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

