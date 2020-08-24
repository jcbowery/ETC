using Unity;

namespace Utilities
{
    public static class UnityContainerFactory
    {
        private static readonly IUnityContainer UnityContainer;

        static UnityContainerFactory()
        {
            UnityContainer = new UnityContainer();
        }

        public static IUnityContainer GetContainer()
        {
            return UnityContainer;
        }
    }
}
