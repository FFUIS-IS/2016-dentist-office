﻿using System;
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
            string sql = "SELECT * FROM [LoginFormTable] WHERE [username] = @username AND [password] = @password";
            SqlCeCommand command = new SqlCeCommand(sql, connection);

            command.Parameters.AddWithValue("@username", user.Username);
            if (user.Username.Length == 0)
                throw new Exception("Username must be filled!");

            command.Parameters.AddWithValue("@password", user.Password);
            if (user.Password.Length == 0)
                throw new Exception("Password must be filled!");


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

