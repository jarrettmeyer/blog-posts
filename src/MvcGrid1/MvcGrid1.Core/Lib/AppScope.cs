using MvcGrid1.Core.Lib.Startup;
using Ninject;
using Ninject.Modules;

namespace MvcGrid1.Core.Lib
{
    public static class AppScope
    {
        private static IKernel _kernel;

        public static IKernel BuildKernel()
        {
            var modules = new INinjectModule[]
            {
                new LinqToSqlDataContextModule()                     
            };
            _kernel = new StandardKernel(modules);
            return _kernel;
        }

        public static T Resolve<T>()
        {
            var kernel = _kernel ?? (_kernel = BuildKernel());
            return kernel.Get<T>();
        }
    }
}
