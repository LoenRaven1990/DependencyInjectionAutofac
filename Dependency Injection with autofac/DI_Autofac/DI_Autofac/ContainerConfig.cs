using Autofac;
using Library;
using System.Reflection;

namespace DI_Autofac;
public static class ContainerConfig
{
    public static IContainer Configure()
    {
        var builder = new ContainerBuilder();

        //builder.RegisterType<Application>().AsSelf();
        builder.RegisterType<Application>().As<IApplication>();
        builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();


        builder.RegisterAssemblyTypes(Assembly.Load(nameof(Library)))
            .Where(t => t.Namespace.Contains("Utilities"))
            .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
        

        return builder.Build();
    }
}
