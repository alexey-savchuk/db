using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Library.Utils
{
    internal class PasswordEncoder
    {
        public String Encode(String password)
        {
            using (SHA256 encoder = SHA256.Create())
            {
                byte[] hash = encoder.ComputeHash(Encoding.ASCII.GetBytes(password));
                return String.Concat(hash.Select(b => b.ToString("x2")));
            }
        }
    }
}
