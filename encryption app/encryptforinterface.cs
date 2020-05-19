using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace encryption_app
{
    class encryptforinterface : Iencryptionblueprint
    {
        public string Decrypt(string text)
        {
            byte[] src = Convert.FromBase64String(text);
            RijndaelManaged aes = new RijndaelManaged();
            byte[] key = Encoding.ASCII.GetBytes("contactcentrT");
            aes.KeySize = 128;
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.ECB;
            using (ICryptoTransform decrypt = aes.CreateDecryptor(key, null))
            {
                byte[] dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                decrypt.Dispose();
                return Encoding.UTF8.GetString(dest);
            }
        }

        public  string Encrypt(string data)
        {
           

                byte[] src = Encoding.UTF8.GetBytes(data);
                byte[] key = Encoding.ASCII.GetBytes("contactcentre");
                RijndaelManaged aes = new RijndaelManaged();
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                aes.KeySize = 128;

                using (ICryptoTransform encrypt = aes.CreateEncryptor(key, null))
                {
                    byte[] dest = encrypt.TransformFinalBlock(src, 0, src.Length);
                    encrypt.Dispose();
                    return Convert.ToBase64String(dest);
                }
            }
    }
}
