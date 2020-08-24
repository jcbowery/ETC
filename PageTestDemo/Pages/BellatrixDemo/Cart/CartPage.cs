using PageTestDemo.Pages.BellatrixDemo.Checkout;
using Selenium;

namespace PageTestDemo.Pages.BellatrixDemo.Cart
{
    public partial class CartPage
    {
        public CartPage AddCoupon(string code)
        {
            CouponCode.SendKeys(code);
            ApplyCouponButton.Click();
            Driver.WaitForAjax();
            return this;
        }

        public CheckoutPage ProceedToCheckout()
        {
            ProceedToCheckoutButton.Click();
            return new CheckoutPage();
        }
    }
}
