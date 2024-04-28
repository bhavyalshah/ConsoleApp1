using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_access_modifiers
{
    class A
    {
        public string a = "C#";
        public void print()
        {
            Console.WriteLine("hello from class a");
        }
    }
        class program { 
        static void Main(string[] args)
        {
                A a1=new A();
                Console.WriteLine("A" + a1.a);
               Console.ReadLine();
        }
    }
}
