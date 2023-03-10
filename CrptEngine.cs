using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace _1_prakt
{
    internal class CrptEngine
    {
        
        public static bool Is8Bytes(string text)
        {
            if (StringToByte(text).Length == 8)
                return true;
            return false;
        }


        static DESCryptoServiceProvider AlgorithmInstance()
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Mode = CipherMode.CBC;
            DES.Padding = PaddingMode.PKCS7;
            return DES;
        }
        
        public static byte[] StringToByte(string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }

        public static string Encryption(string text, string key, string iv)
        { 
            var encryptor = AlgorithmInstance().CreateEncryptor(StringToByte(key), StringToByte(iv));
            return Convert.ToBase64String(encryptor.TransformFinalBlock(Encoding.Unicode.GetBytes(text), 0, Encoding.Unicode.GetBytes(text).Length));
        }
        public static string Decryption(string text, string key, string iv)
        {
            var decryptor = AlgorithmInstance().CreateDecryptor(StringToByte(key), StringToByte(iv));
            return Encoding.Unicode.GetString(decryptor.TransformFinalBlock(Convert.FromBase64String(text), 0, Convert.FromBase64String(text).Length));
        }

    }
}
