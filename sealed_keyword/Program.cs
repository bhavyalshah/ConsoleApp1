using System;
using System.Runtime.InteropServices;

namespace sealed_keyword
{
    class A
    {
        public virtual void show() {
            Console.WriteLine("class A");
        }

    }
    class B : A
    {
        sealed public override void show()
        {
            Console.WriteLine("class B to A");
        }

    }
    //class C : B {
    //    public override void show()
    //    {
    //        Console.WriteLine("class c to B");
    //    }
    //} 
  class Program
    {
        static void Main(string[] args)
        {
       B a = new B();
     
            Console.ReadLine();
           
        }
    }
}
