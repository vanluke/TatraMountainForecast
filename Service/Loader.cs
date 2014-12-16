using Autofac;
using Autofac.Extras.DomainServices;

namespace Service
{
    public class Loader : AutofacDomainServiceModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationContext>().AsSelf();
            base.Load(builder);
        }
    }
}
