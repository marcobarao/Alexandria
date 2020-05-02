using Ninject;
using Ninject.Modules;
public class Resolver
{
    private static IKernel _ninjectKernel;

    public static void Wire(INinjectModule module)
    {
        _ninjectKernel = new StandardKernel(module);
    }

    public static T Resolve<T>()
    {
        return _ninjectKernel.Get<T>();
    }
}