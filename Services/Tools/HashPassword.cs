using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services.Tools
{
    public class HashPassword
    {
        public static string Hash(string password)
        {
            var alg = SHA256.Create();

            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = alg.ComputeHash(asByteArray);

            return Convert.ToBase64String(hashedPassword);
            //
        }

        public static bool Verify(string password, string hashed)
        {
            var alg = SHA256.Create();

            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = alg.ComputeHash(asByteArray);

            return hashed == Convert.ToBase64String(hashedPassword);
        }
    }
}
