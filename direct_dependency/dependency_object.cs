using System;

namespace direct_dependency
{
    public class ClassC
    {
        public void ActionC() => Console.WriteLine("Action in class C");
    }

    public class ClassB
    {
        // phu thuoc classB la classC
        ClassC c_dependency;
        public ClassB(ClassC classC)
        {
            c_dependency = classC;
        }

        public void ActionB()
        {
            Console.WriteLine("Action in class B");
            c_dependency.ActionC();
        }
    }

    public class classA
    {
        //phu thuoc class A la class B
        ClassB _b_dependency;
        public classA(ClassB classB)
        {
            _b_dependency = classB;
        }

        public void ActionA()
        {
            Console.WriteLine("Action in class A");
            _b_dependency.ActionB();
        }
    }
}