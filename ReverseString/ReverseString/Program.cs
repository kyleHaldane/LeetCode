using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((char)((int)'a' + 1));
            Console.WriteLine((char)((int)'s' + 5));
            char[] s = { 'A', ' ', 'm', 'a', 'n', ',', ' ', 'a', ' ', 'p', 'l', 'a', 'n', ',', ' ', 'a', ' ', 'c', 'a', 'n', 'a', 'l', ':', ' ', 'P', 'a', 'n', 'a', 'm', 'a' };
            Solution solution = new Solution();
            solution.ReverseString(s);
        }

        public class Solution
        {
            public void ReverseString(char[] s)
            {
                int count = s.Length / 2;
                int dif;

                for(int i = 0; i < count; ++i)
                {
                    dif = (int)s[i] - (int)s[s.Length - 1 - i];
                    //Console.WriteLine("STARTING VALUE FOR {0},{1}", s[i], s[s.Length - 1 - i]);

                    
                       s[s.Length - 1 - i] = (char)((int)s[s.Length - 1 - i] + dif);
                        s[i] = (char)((int)(s[i]) - dif);

                    //Console.WriteLine("ENDING VALUE FOR {0},{1}", s[i], s[s.Length - 1 - i]);
                }
                Console.WriteLine(s);
            }
        }
    }
}
