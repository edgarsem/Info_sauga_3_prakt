using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;

namespace _3_prakt
{
    internal class CrptEngine
    {

        public static bool CheckStringFormat(string input)
        {
            string[] splitInput = input.Split(',');
            if (splitInput.Length != 2)
            {
                return false;
            }
            bool isNumber1 = int.TryParse(splitInput[0], out int number1);
            bool isNumber2 = int.TryParse(splitInput[1], out int number2);
            return isNumber1 && isNumber2;
        }

        public static bool checkIfNumOnly(String text)
        {
            foreach (char c in text)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public static bool IsPrime(BigInteger n)
        {
            if (n <= 1)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            for (BigInteger i = 3; i <= Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static BigInteger Sqrt(BigInteger n)
        {
            BigInteger root = 0;
            BigInteger bit = 1 << 30;
            while (bit > n)
            {
                bit >>= 2;
            }
            while (bit != 0)
            {
                if (n >= root + bit)
                {
                    n -= root + bit;
                    root += bit << 1;
                }
                root >>= 1;
                bit >>= 2;
            }
            return root;
        }


        private static BigInteger extendedGCD(BigInteger a, BigInteger b, BigInteger[] s, BigInteger[] t)
        {

            if (a == 0)
            {
                s[0] = 0;
                t[0] = 1;
                return b;
            }

            BigInteger[] s1 = new BigInteger[1], t1 = new BigInteger[1];
            BigInteger gcd = extendedGCD(b % a, a, s1, t1);

            s[0] = BigInteger.Subtract(t1[0], BigInteger.Multiply(BigInteger.Divide(b, a), s1[0]));
            t[0] = s1[0];

            return gcd;
        }


        public static String encryptorEngine(String text, BigInteger e, BigInteger n)
        {
            string encryptedText = "";
            for (int i = 0; i < text.Length; i++)
            {
                BigInteger num = BigInteger.ModPow((int)text[i], e, n);
                encryptedText += num.ToString() + " ";
            }
            return encryptedText.Trim();
        }

        public static String decryptorEngine(String text, BigInteger d, BigInteger n)
        {
            string decryptedText = "";
            string[] nums = text.Split(' ');
            
            for (int i = 0; i < nums.Length; i++)
            {
                BigInteger dec = BigInteger.ModPow(BigInteger.Parse(nums[i]), d, n);
                decryptedText += (char)dec;
            }
            return decryptedText;
        }


        public static String keyGen(BigInteger p, BigInteger q, bool keyType)
        {
            BigInteger n = BigInteger.Multiply(p, q);
            BigInteger phi = BigInteger.Multiply(BigInteger.Subtract(p, 1), BigInteger.Subtract(q, 1));
            BigInteger e = 2;
            BigInteger[] x = new BigInteger[1], y = new BigInteger[1];

            BigInteger res = extendedGCD(e, phi, x, y);

            while (e < phi)
            {
                if (res == 1)
                    break;
                else
                    e = BigInteger.Add(e, 1);
                res = extendedGCD(e, phi, x, y);
            }

            BigInteger d = x[0];

            while (d <= 0 || d == e)
                d = BigInteger.Add(d, phi);

            if (keyType)
                return e.ToString() + ", " + n.ToString();
            return d.ToString() + ", " + n.ToString();
        }


        public static BigInteger[] PQfinder(BigInteger n)
        {
            BigInteger[] pq = new BigInteger[2];
            for(BigInteger i = 0; i < n; i++)
            {
                if(IsPrime(i))
                {
                    if(BigInteger.Remainder(n, i) == 0)
                    {
                        pq[0] = i;
                        pq[1] = BigInteger.Divide(n, i);
                        return pq;
                    }
                }

            }
            pq[0] = 0;
            pq[1] = 0;
            return pq;
        }

    }
}
