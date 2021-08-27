using System;
using Microsoft.Extensions.DependencyInjection;

namespace delegate_factory_dependency_injection
{
    public class RunDelegateFactoryDependencyInjection
    {
        public RunDelegateFactoryDependencyInjection()
        {
            ServiceCollection service = new ServiceCollection();
            service.AddSingleton<ClassA, ClassA>();
            service.AddSingleton<IClassC, ClassC>();
            service.AddSingleton<IClassB>((IServiceProvider serviceprovider) =>
            {
                var service_c = serviceprovider.GetService<IClassC>();
                 var sv = new ClassB(service_c, "Thực hiện trong ClassB2");
                return sv;
            });

            var provider = service.BuildServiceProvider();

            ClassA service_a = provider.GetService<ClassA>();
            service_a.ActionA();
        }
    }
}