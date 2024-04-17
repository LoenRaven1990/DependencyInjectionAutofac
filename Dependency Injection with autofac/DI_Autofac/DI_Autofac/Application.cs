using Library;

namespace DI_Autofac;
public class Application : IApplication
{
    protected readonly IBusinessLogic _businessLogic;

    public Application(IBusinessLogic businessLogic)
    {
        _businessLogic = businessLogic;
    }

    public void Run()
    {
        _businessLogic.ProcessData();
    }
}