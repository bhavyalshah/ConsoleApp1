using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface Ipolygon
    {
        void calculateArea(int l, int b);
    }
    class A : Ipolygon
    {
        public void calculateArea(int l, int b)
        {
            int area = l * b;
            Console.WriteLine("Area of Rectangle:" + area);
        }
    }
   
        
    
class Program
    {
        static void Main(string[] args)
        {
        A r1 = new A();
        r1.calculateArea(100, 200);
        }
    }
}
