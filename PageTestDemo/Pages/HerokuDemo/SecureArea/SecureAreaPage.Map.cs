using OpenQA.Selenium;
using Selenium;
using Selenium.Contracts;

namespace PageTestDemo.Pages.HerokuDemo.SecureArea
{
    public partial class SecureAreaPage
    {
        private IElement Toaster => Driver.FindElement(By.Id("flash"));
    }
}
