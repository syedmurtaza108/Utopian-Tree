using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopian_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = utopianTree(n);
                Console.WriteLine(result);

            }



        }

        static int utopianTree(int n)
        {
            int ans = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    ans++;
                else
                    ans *= 2;
            }
            return ans;
        }
    }
}
