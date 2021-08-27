using direct_dependency;
using inverse_dependency;
namespace dependency_injection_c_
{
  
    class Program
    {
        static void Main(string[] args)
        {
            //   RunDirectDependency runDirectDependency = new RunDirectDependency();
              RunInverseDependency runInverseDependency = new RunInverseDependency();
        }
    }
}
