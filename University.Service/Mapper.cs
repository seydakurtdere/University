using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Service
{
    public class Mapper
    {
        public static T Map<S, T>(object source)
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<S, T>();
            });

            AutoMapper.IMapper mapper = config.CreateMapper();
            var result = mapper.Map<S, T>((S)source);

            return result;
        }
    }
}
