using Autofac;

namespace Lab3.Data
{
    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Scan an assembly for components
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.GetExecutingAssembly())
                   .Where(t => t.Name.EndsWith("Fake"))
                   .AsImplementedInterfaces();
            base.Load(builder);
        }
    }
}