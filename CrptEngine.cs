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


        static DESCryptoServiceProvider AlgorithmInstance(int mode)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            switch (mode)
            {
                case 0:
                    DES.Mode = CipherMode.ECB;
                    break;
                case 1:
                    DES.Mode = CipherMode.CBC;
                    break;
                case 2:
                    DES.Mode = CipherMode.CFB;
                    break;
            }
            DES.Padding = PaddingMode.PKCS7;
            return DES;
        }
        
        public static byte[] StringToByte(string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }

        public static string Encryption(string text, string key, string iv, int mode)
        {
            var encryptor = AlgorithmInstance(mode).CreateEncryptor(StringToByte(key), StringToByte(iv));
            return Convert.ToBase64String(encryptor.TransformFinalBlock(Encoding.Unicode.GetBytes(text), 0, Encoding.Unicode.GetBytes(text).Length));
        }
        public static string Decryption(string text, string key, string iv, int mode)
        {
            var decryptor = AlgorithmInstance(mode).CreateDecryptor(StringToByte(key), StringToByte(iv));
            return Encoding.Unicode.GetString(decryptor.TransformFinalBlock(Convert.FromBase64String(text), 0, Convert.FromBase64String(text).Length));
        }

    }
}
