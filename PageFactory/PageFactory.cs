using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using Unity;
using Utilities;

namespace PageFactory
{
    public static class PageFactory //todo make work or learn an alternate to unity
    {
        private static readonly IUnityContainer Container;

        static PageFactory()
        {

            var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = "unity.config" };
            var configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            var unitySection = (UnityConfigurationSection)configuration.GetSection("unity");
            //Container = UnityContainerFactory.GetContainer();//.RegisterInstance(UnityContainerFactory.GetContainer());//new UnityContainer();
            //Container.LoadConfiguration(unitySection);
            UnityContainerFactory.GetContainer().LoadConfiguration(unitySection);



        }

        public static T Get<T>()
        {
            return Container.Resolve<T>();
        }


    }
}
