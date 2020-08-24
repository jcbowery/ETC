using PageTestDemo.Pages.HerokuDemo.Login;
using PageTestDemo.Pages.HerokuDemo.SecureArea;
using Unity;
using Utilities;

namespace PageTestDemo.Pages.Base
{
    public static class IOCClass //todo learn how to use servicecollection
    {


        static public void LoadIoC()
        {
            UnityContainerFactory.GetContainer().RegisterType<ILogin, LoginPage>();
            UnityContainerFactory.GetContainer().RegisterType<ISecureArea, SecureAreaPage>();
        }
    }
}
