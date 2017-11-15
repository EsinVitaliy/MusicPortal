using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;



namespace MusicPortal.Security
{
    public class TripleDES
    {
        public string Encrypt(string data, string key)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            byte[] encryptedData = Encrypt(dataBytes, keyBytes);
            return Convert.ToBase64String(encryptedData);
        }



        public byte[] Encrypt(byte[] data, byte[] key)
        {
            using (var cryptoProvider = new TripleDESCryptoServiceProvider())
            {
                byte[] validKey;

                using (var hashProvider = new SHA256CryptoServiceProvider())
                {
                    var hash = hashProvider.ComputeHash(key);
                    validKey = hash.Take(24).ToArray();
                }

                cryptoProvider.Key = validKey;
                ICryptoTransform cTransform = cryptoProvider.CreateEncryptor();
                return cTransform.TransformFinalBlock(data, 0, data.Length);
            }
        }
    }
}