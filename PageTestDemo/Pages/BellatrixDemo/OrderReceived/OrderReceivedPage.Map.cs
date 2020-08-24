using OpenQA.Selenium;
using Selenium;
using Selenium.Contracts;

namespace PageTestDemo.Pages.BellatrixDemo.OrderReceived
{
    public partial class OrderReceivedPage
    {
        private IElement OrderReceivedMessage => Driver.FindElement(By.XPath("//p[@class='woocommerce-notice woocommerce-notice--success woocommerce-thankyou-order-received']"));
    }
}
