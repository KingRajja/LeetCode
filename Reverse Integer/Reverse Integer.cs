using System;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Reverse(120);
            Console.WriteLine(result);
        }

        public static int Reverse(int x)
        {
            if(x<0)
            {
                x = -x;
                string output = new string(x.ToString().ToCharArray().Reverse().ToArray());
                try { return Convert.ToInt32(output) * -1; } catch { return 0; }
            }
            else
            {
                string output = new string(x.ToString().ToCharArray().Reverse().ToArray());
                try { return Convert.ToInt32(output); } catch { return 0; }
            }
            
            
        }
    }
}
