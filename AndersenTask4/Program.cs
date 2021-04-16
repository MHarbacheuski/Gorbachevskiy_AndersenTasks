using System;

namespace AndersenTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "[((())()(())]]";
            check(s);
            Console.WriteLine(s);
        }
        static public bool check(string s)
        {
            int counter = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
                if (counter < 0)
                {
                    return false;
                }
            }
            return counter == 0;
        }
    }
}
