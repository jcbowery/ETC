using PageTestDemo.Pages.BellatrixDemo.OrderReceived;
using Selenium;

namespace PageTestDemo.Pages.BellatrixDemo.Checkout
{
    public partial class CheckoutPage
    {
        public CheckoutPage EnterName(string first, string last)
        {
            FirstName.SendKeys(first);
            LastName.SendKeys(last);
            return this;
        }

        public CheckoutPage EnterCompanyName(string company)
        {
            CompanyName.SendKeys(company);
            return this;
        }

        public CheckoutPage SelectCountry()
        {

            Country_US.Click();
            return this;
        }

        public CheckoutPage EnterAddress(string street, string apartment)
        {
            Street.SendKeys(street);
            Apartment.SendKeys(apartment);
            return this;
        }

        public CheckoutPage EnterCity(string city)
        {
            Town_City.SendKeys(city);
            return this;
        }

        public CheckoutPage SelectState()
        {
            State_FL.Click();
            return this;
        }

        public CheckoutPage EnterZip(string zip)
        {
            Zip.SendKeys(zip);
            return this;
        }

        public CheckoutPage EnterPhoneNumber(string pn)
        {
            Phone.SendKeys(pn);
            return this;
        }

        public CheckoutPage EnterEmail(string email)
        {
            Email.SendKeys(email);
            return this;
        }

        public CheckoutPage RegisterAccount()
        {
            CreateAccount.Click();
            return this;
        }

        public OrderReceivedPage PlaceOrder()
        {
            PlaceOrderButton.Click();
            Driver.WaitForAjax();
            return new OrderReceivedPage();
        }
    }
}
