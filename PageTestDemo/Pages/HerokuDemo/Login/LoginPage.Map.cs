using OpenQA.Selenium;
using Selenium;
using Selenium.Contracts;

namespace PageTestDemo.Pages.HerokuDemo.Login
{
    public partial class LoginPage
    {
        private IElement UserName => Driver.FindElement(By.Id("username"));
        private IElement Password => Driver.FindElement(By.Id("password"));
        private IElement LoginButton => Driver.FindElement(By.XPath("//i[@class='fa fa-2x fa-sign-in']"));
    }
}
