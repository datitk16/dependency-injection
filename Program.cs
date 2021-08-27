using direct_dependency;
using inverse_dependency;
using dependency_injection;
using delegate_factory_dependency_injection;
namespace dependency_injection_c_
{

    class Program
    {
        static void Main(string[] args)
        {
            //   RunDirectDependency runDirectDependency = new RunDirectDependency();
            //   RunInverseDependency runInverseDependency = new RunInverseDependency();
            // RunDependencyInjection runDependencyInjection = new RunDependencyInjection();
            RunDelegateFactoryDependencyInjection runDelegateFactoryDependencyInjection = new RunDelegateFactoryDependencyInjection();
        }
    }
}
