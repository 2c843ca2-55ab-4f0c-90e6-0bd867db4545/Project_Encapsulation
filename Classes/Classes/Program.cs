using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class A
    {
        public virtual void show()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public override void show()
        {
            Console.WriteLine("B");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A ObjA1 = new A();
            //ObjA.show();

            B ObjB = new B();
            //ObjB.show();
            //object p = ObjA1;
            object p = ObjB;

            A Obja = (A)p;
            Obja.show();



            //ObjB = Obja;
            //ObjB.show();


            //B Objb = new A();
            //Objb.show();

            Console.ReadLine();


        }
    }
}
