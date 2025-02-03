using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnricCLasses
{
    internal class Program
    {

        delegate int ty1 (int x, int y);
        delegate double ty2 (double x, double y);
        delegate string ty3();

        static void Main(string[] args)
        {

            ty1 m1 = new ty1(cvre);
            ty2 m2 = new ty2(alan);
            ty3 m3 = new ty3(d);

            Console.WriteLine(m3);

            Console.WriteLine(m1(5, 10).ToString());
            Console.WriteLine(m2(11.0, 23.4).ToString());
            Console.ReadLine();


            
        }

        public static int cvre(int x, int y)
        {
            return 2*(x + y);
        }
        public static double alan(double x, double y) 
        {
            return x * y;
        }

        private static string d()
        {
            return Console.ReadLine();  
        }

        class 

        
    }
}
