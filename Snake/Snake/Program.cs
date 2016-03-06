using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine lineH1 = new HorizontalLine(5, 10, 7, '+');
            lineH1.Drow();

            VerticalLine lineV1 = new VerticalLine(5, 10, 11, '+');
            lineV1.Drow();

            VerticalLine lineV2 = new VerticalLine(5, 10, 4, '+');
            lineV2.Drow();

            Console.ReadLine();
        }
    }
}