using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Types.Attributes;

namespace ManageFlow.Delegates
{
    public class GenericRepository<TObject> where TObject : class, IEntity
    {
        public static List<User> _users = new List<User>()
        {
            new User() {Id = 1, CreatedAt = DateTime.Now, CreatedBy = 1, Removed = false, Name = "Jan", Email = "test@trst.pl", Password = "secret", Age = 15},
            new User() {Id = 1, CreatedAt = DateTime.Now, CreatedBy = 1, Removed = true, Name = "Adam", Email = "test1@trst.pl", Password = "secret1", Age = 15}
        };

        public ICollection<TObject> GetAll()
        {
            return Query().ToList();
        }

        public TObject Get(int id)
        {
            return Query().FirstOrDefault(r => r.Id == id);
        }

        public TObject First(Expression<Func<TObject, bool>> match)
        {
            return Query().FirstOrDefault(match);
        }

        public TObject Single(Expression<Func<TObject, bool>> match)
        {
            return Query().SingleOrDefault(match);
        }

        public bool Any(Expression<Func<TObject, bool>> match)
        {
            return Query(match).Any();
        }
        
        public IQueryable<TObject> InternalQuery()
        {
            // var conditionMatch = GetPermissionsCondition();
            // return Context.Set<TObject>().Where(conditionMatch);
            

            return _users.Where(r => !r.Removed) as IQueryable<TObject>;
        }

        public IQueryable<TObject> Query(Expression<Func<TObject, bool>> match)
        {
            return InternalQuery().Where(match);
        }

        public IQueryable<TObject> Query()
        {
            return InternalQuery().Where(r => !r.Removed);
        }

    }
}