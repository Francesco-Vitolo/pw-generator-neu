using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatorPW
{
    public static class CreatePW
    {
        public static string Password { get; private set; }

        private const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LowerCase = "abcdefghijklmnopqrstuvwxyz";
        private const string Sonderzeichen = "!.,_-#'+-*/()[]{}";
        private static readonly Random Rand = new Random();
        public static string Create(int length)
        {
            Password = "";
            for (int i = 0; i < length; i++)
            {
                switch(Rand.Next(1, 4))
                {
                    case 1:
                        Password += UpperCase[Rand.Next(0, 26)];
                        break;
                    case 2:
                        Password += LowerCase[Rand.Next(0, 26)];
                        break;
                    case 3:
                        Password += Sonderzeichen[Rand.Next(0, Sonderzeichen.Length)];
                        break;
                }
            }
            return Password;
        }
    }
}
