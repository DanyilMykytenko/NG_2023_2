using BLL.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Mapping;

namespace WebAPI.Extensions
{
    public static class AddMapperExtension
    {
        public static void AddMapper(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(AutoMapperProfileWeb));
        }
    }
}
