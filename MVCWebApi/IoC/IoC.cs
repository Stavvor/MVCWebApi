using MVCWebApi.Repositories;
using MVCWebApi.Services;
using Ninject;
using Ninject.Modules;

namespace MVCWebApi
{
    public class IoC : NinjectModule
    {

        public void Setup()
        {
            Load();
        }

        public T Get<T>()
        {
            return Kernel.Get<T>();
        }

        public override void Load()
        {
            //Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            //Bind(typeof(IService<>)).To(typeof(Service<>));
        }
    }
}
