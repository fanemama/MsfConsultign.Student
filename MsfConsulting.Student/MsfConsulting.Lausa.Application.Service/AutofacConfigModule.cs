using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service
{
    public class AutofacConfigModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            //builder.RegisterType<MyService>().As<IService>();

            //// Other Lifetime
            //// Transient
            //builder.RegisterType<MyService>().As<IService>()
            //    .InstancePerDependency();

            //// Scoped
            //builder.RegisterType<MyService>().As<IService>()
            //    .InstancePerLifetimeScope();

            //builder.RegisterType<MyService>().As<IService>()
            //    .InstancePerRequest();

            //// Singleton
            //builder.RegisterType<MyService>().As<IService>()
            //    .SingleInstance();

            // Scan an assembly for components
            //builder.RegisterAssemblyTypes(typeof(Startup).Assembly)
            //       .Where(t => t.Name.EndsWith("Service"))
            //       .AsImplementedInterfaces();
        }
    }
}
