using HappyCamp.DataAccess.Converters;
using HappyCamp.DataAccess.Entities;
using HappyCamp.Domain.DTOs;

namespace HappyCamp.DataAccess.Service
{
    abstract class AbstractSQLService<T>
        where T : DTO
    {
        // private CRUDService<K> Service { get; set; }
        // private BaseConverter<T, K> DTOToEntityConverter { get; set; }
        // private BaseConverter<K, T> EntityToDTOConverter { get; set; }

        private IConverterManager ConverterManager { get; set; }

        protected AbstractSQLService(BaseConverter<T, K> DTOToEntityConverter, BaseConverter<K, T> EntityToDTOConverter)
        {
            this.DTOToEntityConverter = DTOToEntityConverter;
            this.EntityToDTOConverter = EntityToDTOConverter;
        }

        public T Get(long id)
        {
            K entity = this.Service.Get(id);
            return this.EntityToDTOConverter.Convert(entity);
        }
        public T Create(T dto)
        {
            K entity = this.DTOToEntityConverter.Convert(dto);
            entity = this.Service.Create(entity);
            return this.EntityToDTOConverter.Convert(entity);
        }
        public bool Delete(long id)
        {
            return this.Service.Delete(id);
        }
        public bool Update(T dto)
        {
            K entity = this.DTOToEntityConverter.Convert(dto);
            return this.Service.Update(entity);
        }
    }

    internal abstract class ConverterManager<T, K> : IConverterManager
        where T : DTO, new()
        where K : Entity, new()
    {
        public ConverterManager()
        {
        }

        private BaseConverter<T, K> DTOToEntityConverter { get; set; }

        private BaseConverter<K, T> EntityToDTOConverter { get; set; }

        K IConverterManager.FromDTO<K, T>(T dto)
        {
            throw new System.NotImplementedException();
        }

        CRUDService<K> GetService<K>()
        {
            throw new System.NotImplementedException();
        }

        T IConverterManager.ToDTO<T, K>(K entity)
        {
            throw new System.NotImplementedException();
        }
    }

    interface IConverterManager
    {
        CRUDService<K> GetService<K>()
            where K : Entity;
        T ToDTO<T, K>(K entity)
            where T : DTO
            where K : Entity;
        K FromDTO<K, T>(T dto)
            where T : DTO
            where K : Entity;
;
    }
}
