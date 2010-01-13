using MvcGrid1.Core.Lib.Data;
using MvcGrid1.Core.Models;
using Ninject.Modules;

namespace MvcGrid1.Core.Lib.Startup
{
    public class LinqToSqlDataContextModule : NinjectModule
    {
        private static LinqToSqlRepository BuildRepository()
        {
            var dc = new MvcGrid1DataContext();
            return new LinqToSqlRepository(dc);
        }

        public override void Load()
        {
            Bind<IRepository>().ToMethod(c => BuildRepository());
        }
    }
}
