using HappyCamp.DataAccess.Converters;
using HappyCamp.DataAccess.Entities;
using HappyCamp.Domain.DTOs;

namespace HappyCamp.DataAccess.Service
{
    abstract class AbstractSQLService<TDTO>
        where TDTO : DTO
    {
        internal class CRUDServiceDelegate<KEntity>
            where KEntity : Entity
        {
            private CRUDService<KEntity> Service { get; set; }
            private IConverter DTOToEntityConverter { get; set; }
            private IConverter EntityToDTOConverter { get; set; }

            public TDTO Get(long id)
            {
                KEntity entity = this.Service.Get(id);
                return this.EntityToDTOConverter.Convert<KEntity, TDTO>(entity);
            }
            public TDTO Create(TDTO dto)
            {
                KEntity entity = this.DTOToEntityConverter.Convert<TDTO, KEntity>(dto);
                entity = this.Service.Create(entity);
                return this.EntityToDTOConverter.Convert<KEntity, TDTO>(entity);
            }
            public bool Delete(long id)
            {
                return this.Service.Delete(id);
            }
            public bool Update(TDTO dto)
            {
                KEntity entity = this.DTOToEntityConverter.Convert<TDTO, KEntity>(dto);
                return this.Service.Update(entity);
            }
        }

        private IConverter DTOToEntityConverter { get; set; }
        private IConverter EntityToDTOConverter { get; set; }

        private CRUDServiceDelegate<Entity> Delegate { get; set; }

        protected AbstractSQLService(IConverter DTOToEntityConverter, IConverter EntityToDTOConverter, CRUDServiceDelegate<Entity> Delegate)
        {
            this.DTOToEntityConverter = DTOToEntityConverter;
            this.EntityToDTOConverter = EntityToDTOConverter;
            this.Delegate = Delegate;
        }

        public TDTO Get(long id)
        {
            return this.Delegate.Get(id);
        }
        public TDTO Create(TDTO dto)
        {
            return this.Delegate.Create(dto);
        }
        public bool Delete(long id)
        {
            return this.Delegate.Delete(id);
        }
        public bool Update(TDTO dto)
        {
            return this.Delegate.Update(dto);
        }
    }
}
