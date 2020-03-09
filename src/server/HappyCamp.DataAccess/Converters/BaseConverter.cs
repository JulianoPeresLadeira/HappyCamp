using AutoMapper;

namespace HappyCamp.DataAccess.Converters
{
    abstract class BaseConverter<T, K> : IConverter<T, K>
        where T : class, new()
        where K : class, new()
    {

        private static IMapper Mapper { get; set; }

        protected BaseConverter()
        {
            Mapper = CreateMapper();
        }

        public K Convert(T from)
        {
            IMapper mapper = this.CreateMapper();
            K to = mapper.Map<K>(from);
            this.DoConvert(from, to);
            return to;
        }

        protected virtual void DoConvert(T from, K to)
        {
        }

        protected virtual IMapper CreateMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg => cfg.CreateMap<T, K>());
            return config.CreateMapper();
        }
    }
}
