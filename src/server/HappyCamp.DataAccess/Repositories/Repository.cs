using System;
using System.Collections.Generic;
using System.Text;
using HappyCamp.DataAccess.Service;
using HappyCamp.Domain.DTOs;
using HappyCamp.Domain.Service;

namespace HappyCamp.DataAccess.Repositories
{
    public abstract class Repository<T> : IService<T>
        where T : DTO
    {
        private IService<T> Service;

        public Repository()
        {
            this.Service = GetService();
        }

        public T Create(T obj)
        {
            return Service.Create(obj);
        }

        public bool Delete(long id)
        {
            return Service.Delete(id);
        }

        public T Get(long id)
        {
            return Service.Get(id);
        }

        public bool Update(T obj)
        {
            return Service.Update(obj);
        }

        protected abstract IService<T> GetService();
    }
}
