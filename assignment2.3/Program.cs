using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._3
{
    public class Assignment2_3
    {

        public static void Main(string[] args)
        {
            string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
            string text = "jopa " + Colors.YELLOW + "gavno";
            Console.WriteLine(text);
        }
    }
}
