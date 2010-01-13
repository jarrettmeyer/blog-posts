using System;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;

namespace MvcGrid1.Core.Lib.Data
{
    public class LinqToSqlRepository : IRepository
    {
        private readonly DataContext _dataContext;

        public LinqToSqlRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Commit()
        {
            _dataContext.SubmitChanges();
        }

        public void Delete<T>(T deleted) where T : class
        {
            var table = ResolveTable<T>();
            table.DeleteOnSubmit(deleted);
        }

        public IQueryable<T> FindAll<T>() where T : class
        {
            return ResolveTable<T>();            
        }

        public IQueryable<T> Find<T>(Expression<Func<T, bool>> expression) where T : class
        {
            var table = ResolveTable<T>();
            return table.Where(expression);
        }

        public T FindSingle<T>(Expression<Func<T, bool>> expression) where T : class
        {
            var table = ResolveTable<T>();
            return table.First(expression);
        }

        public void Insert<T>(T inserted) where T : class
        {
            var table = ResolveTable<T>();
            table.InsertOnSubmit(inserted);
        }

        private Table<T> ResolveTable<T>() where T : class
        {
            return _dataContext.GetTable<T>();
        }
    }
}
