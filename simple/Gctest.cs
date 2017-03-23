// Copyright: 2017, CBS/DTU
// Authors: Rasmus Ulslev Pedersen, Martin Schoeberl
// License: Simplified BSD License
// gcl-safe: simple GC testing

namespace Gclrt
{
    class A
    {
        public void RunMeA()
        {
            Console.Out.WriteLine("[A] I am dying");
        }
    }
    
    class B
    {
        public void RunMeB()
        {
            Console.Out.WriteLine("[B] I am dying");
        }
    }
    
    class C
    {
        public void RunMeC()
        {
            Console.Out.WriteLine("[C] I am dying");
        }
    }
        
    class Gctest
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("[Gctest.cs] Hello hello");
            A a = new A();
            a.RunMeA();
            B b = new B();
            b.RunMeB();
            C c = new C();
            c.RunMeC();
            Console.Out.WriteLine("[Gctest.cs] Bye bye");
            System.GC.Collect();
        }
    }

}