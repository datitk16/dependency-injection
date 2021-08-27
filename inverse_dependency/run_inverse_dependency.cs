
/*
Thiết kế theo cách đảo ngược phụ thuộc Inverse Dependency
*/
namespace inverse_dependency
{
    public class RunInverseDependency
    {
        public RunInverseDependency()
        {
            IClassC objectC = new ClassC();
            IClassB objectB = new ClassB(objectC);
            ClassA objectA = new ClassA(objectB);

            objectA.ActionA();
        }

    }
}