using Business.Abstract;
using Business.Concretes;
using DataAccess.Abstract;
using DataAccess.Concretes.EntityFramework;
using Microsoft.AspNetCore.Builder;

namespace WepAPI
{
    public class Startup
    {
        //public void Configure(IApplicationBuilder app)
        //{
        //    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IProductService, ProductManager >();
            services.AddSingleton<IProductDal, EfProductDal>();
        }
    }
}
