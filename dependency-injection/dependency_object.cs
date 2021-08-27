using System;

namespace dependency_injection
{

    public interface IClassB
    {
        public void ActionB();
    }

    public interface IClassC
    {
        public void ActionC();
    }

    public class ClassC : IClassC
    {
        public ClassC()
        {
            Console.WriteLine("Class C is created");
        }
        public void ActionC()
        {
            Console.WriteLine("Action in class C");
        }
    }

    public class ClassB : IClassB
    {

        IClassC c_denpendency;
        public ClassB(IClassC classC)
        {
            Console.WriteLine("Class B is created");
            c_denpendency = classC;
        }

        public void ActionB()
        {
            Console.WriteLine("Action in class B");
            c_denpendency.ActionC();
        }

    }

    public class ClassA
    {
        IClassB b_dependency;
        public ClassA(IClassB classB)
        {
            b_dependency = classB;
            Console.WriteLine("Class A is created");
        }

        public void ActionA()
        {
            Console.WriteLine("Action in class A");
            b_dependency.ActionB();
        }
    }

}