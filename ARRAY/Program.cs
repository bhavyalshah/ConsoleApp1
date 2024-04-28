using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY { 
   class Program
    {
        static void Main(string[] args)
        {
           int[,] arr= { { 1, 2, 3, 4, }, { 5, 6, 7, 8, } } ;
          

            Console.WriteLine("at 1st pos:" + arr[0,0]);
            Console.WriteLine("at 2nd pos:" + arr[1,0]);
           
            Console.ReadKey();  
        }
    }
}
