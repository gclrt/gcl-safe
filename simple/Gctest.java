// Copyright: 2017, CBS/DTU
// Authors: Rasmus Ulslev Pedersen, Martin Schoeberl
// License: Simplified BSD License
// gcl-safe: simple GC testing

class A
{
    public void RunMeA()
    {
        System.out.println("[A] I am dying");
    }
}

class B
{
    public void RunMeB()
    {
        System.out.println("[B] I am dying");
    }
}

class C
{
    public void RunMeC()
    {
        System.out.println("[C] I am dying");
    }
}
    
public class Gctest
{
    public static void main(String[] args)
    {
        System.out.println("[Gctest.java] Hello hello");
        A a = new A();
        a.RunMeA();
        B b = new B();
        b.RunMeB();
        C c = new C();
        c.RunMeC();
        System.out.println("[Gctest.java] Bye bye");
        System.gc();
    }
}
