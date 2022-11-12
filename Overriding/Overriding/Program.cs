using System;


namespace Overriding
{
    public abstract class A
    {
        public virtual void Foo()
        {
            Console.WriteLine("A:Foo");
        }

        public void Bar()
        { 
            Console.WriteLine("A:Bar");
        }

        public abstract void Zet();
       
    }

    public class B : A
    {
        public override void Foo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("B:Foo");
            Console.ResetColor();
        }

        public override void Zet()
        {
            Console.WriteLine("B-Zet");
        }
    }

    public class C : A
    {
        public override void Foo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("C:Foo");
            Console.ResetColor();
        }

        public override void Zet()
        {
            Console.WriteLine("C-Zet");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            A nesne = new C();

            nesne.Foo();

            nesne.Zet();
        }
    }
}
