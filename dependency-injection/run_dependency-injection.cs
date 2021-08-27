using Microsoft.Extensions.DependencyInjection;

namespace dependency_injection
{
    public class RunDependencyInjection
    {
        public RunDependencyInjection(){
            ServiceCollection service = new ServiceCollection();
            service.AddSingleton<ClassA,ClassA>();
            service.AddSingleton<IClassC,ClassC>();
            service.AddSingleton<IClassB,ClassB>();

            var provider = service.BuildServiceProvider();

            ClassA service_a = provider.GetService<ClassA>();
            service_a.ActionA();
        }
    }
}