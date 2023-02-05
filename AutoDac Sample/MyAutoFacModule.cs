

using AutoDac_Sample.Services;
using Autofac;
using Autofac.Core;

namespace AutoDac_Sample
{
    public class MyAutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerLifetimeScope();
            //builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();

            //از هر دو روش بالا می توان استفاده کرد ولی روش پایین خیلی مختصر تر می باشد


            builder.RegisterAssemblyTypes(typeof(ProductService).Assembly).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

        }
    }
}
