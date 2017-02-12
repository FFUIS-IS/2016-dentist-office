using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrd
{
    class HashPassword
    {
        private static string hashPassword(string password)
        {
            SHA256Managed sha256 = new SHA256Managed();

            byte[] passwordInBytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(passwordInBytes);

            return Convert.ToBase64String(hash);
        }

        public static string HashNewPassword(string password)
        {
            return hashPassword(password);
        }
    }
}
