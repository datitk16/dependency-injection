
/*
Thiết kế truyền thống - tham chiếu trực tiếp đến Dependency
*/
namespace direct_dependency
{
    public class RunDirectDependency
    {
        public RunDirectDependency()
        {
            ClassC objectC = new ClassC();
            ClassB objectB = new ClassB(objectC);
            classA objectA = new classA(objectB);
            objectA.ActionA();
        }
    }
}