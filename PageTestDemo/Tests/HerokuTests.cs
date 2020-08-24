using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageTestDemo.Pages.HerokuDemo.Login;
using Unity;
using Utilities;

namespace PageTestDemo.Tests
{
    [TestClass]
    public class HerokuTests : BaseTest
    {
        [TestMethod]
        public void LoginTest()
        {
            UnityContainerFactory.GetContainer().Resolve<LoginPage>()
                .Navigate("https://the-internet.herokuapp.com/login")
                .EnterUserName("tomsmith")
                .EnterPassword("SuperSecretPassword!")
                .ClickLoginButton()
                .GreenToasterMessage("You logged into a secure area!\r\n×");

        }

        [TestMethod]
        public void LoginTest1()
        {
            UnityContainerFactory.GetContainer().Resolve<LoginPage>()
                .Navigate("https://the-internet.herokuapp.com/login")
                .EnterUserName("tomsmith")
                .EnterPassword("SuperSecretPassword!")
                .ClickLoginButton()
                .GreenToasterMessage("You logged into a secure area!\r\n×");

        }

        [TestMethod]
        public void LoginTest2()
        {
            UnityContainerFactory.GetContainer().Resolve<LoginPage>()
                .Navigate("https://the-internet.herokuapp.com/login")
                .EnterUserName("tomsmith")
                .EnterPassword("SuperSecretPassword!")
                .ClickLoginButton()
                .GreenToasterMessage("You logged into a secure area!\r\n×");

        }

        [TestMethod]
        public void LoginTest3()
        {
            UnityContainerFactory.GetContainer().Resolve<LoginPage>()
                .Navigate("https://the-internet.herokuapp.com/login")
                .EnterUserName("tomsmith")
                .EnterPassword("SuperSecretPassword!")
                .ClickLoginButton()
                .GreenToasterMessage("You logged into a secure area!\r\n×");

        }

        [TestMethod]
        public void LoginTest4()
        {
            UnityContainerFactory.GetContainer().Resolve<LoginPage>()
                .Navigate("https://the-internet.herokuapp.com/login")
                .EnterUserName("tomsmith")
                .EnterPassword("SuperSecretPassword!")
                .ClickLoginButton()
                .GreenToasterMessage("You logged into a secure area!\r\n×");

        }

        [TestMethod]
        public void Experiment()
        {


        }
    }
}
