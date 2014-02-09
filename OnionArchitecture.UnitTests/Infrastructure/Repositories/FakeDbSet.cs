using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.UnitTests.Infrastructure.Repositories
{
    public class FakeDbSet<T> : IDbSet<T>
        where T : class
    {
        private readonly List<T> _items;

        public FakeDbSet()
        {
            _items = new List<T>();
        }

        public FakeDbSet(List<T> items)
        {
            _items = items;
        }

        public T Add(T entity)
        {
            _items.Add(entity);
            return entity;
        }

        public T Attach(T entity)
        {
            throw new NotImplementedException();
        }

        TDerivedEntity IDbSet<T>.Create<TDerivedEntity>()
        {
            throw new NotImplementedException();
        }

        public T Create()
        {
            throw new NotImplementedException();
        }

        public T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.ObservableCollection<T> Local
        {
            get { throw new NotImplementedException(); }
        }

        public T Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Type ElementType
        {
            get { throw new NotImplementedException(); }
        }

        public System.Linq.Expressions.Expression Expression
        {
            get { return _items.AsQueryable().Expression; }
        }

        public IQueryProvider Provider
        {
            get { return _items.AsQueryable().Provider; }
        }
    }

    public static class ExtensionMethod
    {
        public static FakeDbSet<T> AsFakeDbSet<T>(this IEnumerable<T> items)
            where T : class
        {
            return new FakeDbSet<T>(items.ToList());
        }
    }

}
