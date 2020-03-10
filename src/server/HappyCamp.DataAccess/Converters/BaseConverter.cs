using AutoMapper;

namespace HappyCamp.DataAccess.Converters
{
    abstract class BaseConverter : IConverter
    {

        private IMapper Mapper { get; set; }

        protected BaseConverter()
        {
        }

        public virtual K Convert<T, K>(T from)
        {
            IMapper mapper = this.GetMapper<T, K>();
            K to = mapper.Map<K>(from);
            this.DoConvert(from, to);
            return to;
        }

        protected virtual void DoConvert<T, K>(T from, K to)
        {
        }

        private IMapper GetMapper<T, K>()
        {
            if (this.Mapper == null)
            {
                this.Mapper = this.CreateMapper<T, K>();
            }

            return this.Mapper;
        }

        protected virtual IMapper CreateMapper<T, K>()
        {
            MapperConfiguration config = new MapperConfiguration(cfg => cfg.CreateMap<T, K>());
            return config.CreateMapper();
        }
    }
}
