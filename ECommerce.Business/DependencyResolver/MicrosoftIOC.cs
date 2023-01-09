using ECommerce.Business.Concreate;
using ECommerce.Business.Services;
using ECommerce.DataAccess;
using ECommerce.DataAccess.Concreate;
using ECommerce.DataAccess.Interfaces;
using ECommerce.Entities.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.DependencyResolver
{
    public static class MicrosoftIOC
    {
        public static void AddCustomDependencies(this IServiceCollection services)
        {
            //Context Dep. Eklendi
            
            services.AddDbContext<ECommerceContext>();

            //Generic Classlar Dep. Eklendi
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
            services.AddTransient(typeof(ICategoryService), typeof(CategoryManager));
            services.AddTransient(typeof(ICategoryDal), typeof(CategoryRepository));


            //İş Bitince Düşer Çağırılınca Yenisi Dep. İle Gelir...
            //services.AddScoped<ICariAdresService, CariAdresManager>();
            //services.AddScoped<ICariAdresDal, CariAdresRepository>();

            //Runtimeda oluşur her zaman tekildir aynı statik class gibi çalışır
            //services.AddSingleton<adadsadas asdasdasd >

            //her çağırılışta farklı bir örnek verir
            //services.AddTransient<assdasd asdasd > ();
        }

    }
}