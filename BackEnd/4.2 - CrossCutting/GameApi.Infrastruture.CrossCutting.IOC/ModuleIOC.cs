using Autofac;

namespace GameApi.Infrastruture.CrossCutting.IOC
{
    public class ModuleIOC: Module
    {
       protected override void Load(ContainerBuilder builder)
        {
            Configuration.Load(builder);
        }
    }
}