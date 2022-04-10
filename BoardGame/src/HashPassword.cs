using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BoardGame.src
{
    class HashPassword
    {
        public static string HashString(string password)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in GetHash(password))
            {
                stringBuilder.Append(b.ToString("x2"));
            }
            return stringBuilder.ToString();
        }

        public static byte[] GetHash(string password)
        {
            using (HashAlgorithm hashAlgorithm = SHA256.Create())
            {
                return hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
