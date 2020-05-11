using System;

namespace Collections
{
    class Utils
    {
        public static int GetNumber(string prompt, int maxNum)
        {
            int number;
            do
            {
                number = GetNumber(prompt);
                if (number <= maxNum)
                {
                    break;
                }
                Console.WriteLine("number is > " + maxNum + ". Reenter.");
            } while (true);

            return number;
        }

        public static int GetNumber(string prompt)
        {
            int number;
            string strNumber;
            do
            {
                strNumber = GetInput(prompt);
                if (Int32.TryParse(strNumber, out number))
                {
                    break;
                }
                Console.WriteLine("Not an integer. Reenter.");
            } while (true);

            return number;
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }

        public static int GetRandom(int max)
        {
            Random rand = new Random();
            return rand.Next(0, max);
        }
    }
}
