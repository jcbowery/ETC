using OpenQA.Selenium;
using Selenium;
using Selenium.Contracts;

namespace PageTestDemo.Pages.BellatrixDemo.Checkout
{
    public partial class CheckoutPage
    {
        private IElement FirstName => Driver.FindElement(By.Id("billing_first_name"));
        private IElement LastName => Driver.FindElement(By.Id("billing_last_name"));
        private IElement CompanyName => Driver.FindElement(By.Id("billing_company"));
        private IElement Country_US => Driver.FindElement(By.XPath("//*[contains(text(),'United States (US)')]"));
        private IElement Street => Driver.FindElement(By.Id("billing_address_1"));
        private IElement Apartment => Driver.FindElement(By.Id("billing_address_2"));
        private IElement Town_City => Driver.FindElement(By.Id("billing_city"));
        private IElement State_FL => Driver.FindElement(By.XPath("//*[contains(text(),'Florida')]"));
        private IElement Zip => Driver.FindElement(By.Id("billing_postcode"));
        private IElement Phone => Driver.FindElement(By.Id("billing_phone"));
        private IElement Email => Driver.FindElement(By.Id("billing_email"));
        private IElement CreateAccount => Driver.FindElement(By.Id("createaccount"));
        private IElement PlaceOrderButton => Driver.FindElement(By.Id("place_order"));


    }
}
