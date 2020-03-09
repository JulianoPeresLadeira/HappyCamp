using HappyCamp.DataAccess.Context;
using HappyCamp.DataAccess.Entities;

namespace HappyCamp.DataAccess.Service
{
    class CRUDService<T>
        where T : Entity
    {
        public T Get(long id)
        {
            using (var context = new SQLServerContext())
            {
                return context.Set<T>().Find(id);
            }
        }
        public bool Delete(long id)
        {
            using (var context = new SQLServerContext())
            {
                T entity = context.Set<T>().Find(id);
                if (entity != null)
                {
                    context.Remove(entity);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }
        public T Create(T entity)
        {
            using (var context = new SQLServerContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
                return entity;
            }
        }
        public bool Update(T entity)
        {
            using (var context = new SQLServerContext())
            {
                if (context.Set<T>().Find(entity) != null)
                {
                    context.Update(entity);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }

    }
}
