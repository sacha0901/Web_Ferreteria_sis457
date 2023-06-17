using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CadFerreteria.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
//using CadFerreteria.Interfaces;
//using CadFerreteria.Implementacion;
//using ClnFerreteria.Interfaces;
//using CnlFerreteria.Implementacion;

namespace IocFerreteria
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbventaContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
            });
        }
    }
}
