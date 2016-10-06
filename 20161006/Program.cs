using System;
using System.Text;

namespace ConsoleApplication
{
    public class Program
    {
        public int MultipleTwo (int x) => x*2;
        public DateTime Created { get; set; } = DateTime.Now;

        public static void Main()
        {
            
            StringBuilder st = null;
            string output = st?.ToString();

            Console.WriteLine("Hello friend! {0}", st);
        }
    }
}
