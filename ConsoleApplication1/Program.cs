using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> ints = Enumerable.Range(1, 10);
            foreach (int i in ints)
            {
                Console.WriteLine("Hello world!");
            }
        }
    }
}
