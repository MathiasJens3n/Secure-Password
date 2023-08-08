using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Password
{
    internal class HashManager
    {
        int hashIterations = 10000000;

        public byte[] HashPassword(byte[] password, byte[] salt)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes(password, salt, hashIterations, HashAlgorithmName.SHA256))
            {
                return rfc2898.GetBytes(32);
            };
        }
        public byte[] GenerateSalt()
        {
            const int saltSize = 32;
            byte[] randomSalt = new byte[saltSize];

            RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();

            randomNumberGenerator.GetBytes(randomSalt);

            return randomSalt;
        }
        public bool CheckHash(byte[] a, byte[] b)
        {
            for (int i = 0; i < a.Length / 8; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
                
            }
            return true;

        }
    }
}
