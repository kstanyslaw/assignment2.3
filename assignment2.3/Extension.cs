using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._3
{
    internal static class Extension
    {
        public static string FioExtension(this string input)
        {
            string[] fullFio = input.Split(' ', '.');
            return fullFio[0] + fullFio[1][0] + fullFio[2][0];
        }
    }
}
