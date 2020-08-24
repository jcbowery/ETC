using OpenQA.Selenium;
using Selenium;
using Selenium.Contracts;

namespace PageTestDemo.Pages.BellatrixDemo.Cart
{
    public partial class CartPage
    {
        private IElement CouponCode => Driver.FindElement(By.Id("coupon_code"));
        private IElement ApplyCouponButton => Driver.FindElement(By.Name("apply_coupon"));
        private IElement ProceedToCheckoutButton => Driver.FindElement(By.XPath("//a[@class='checkout-button button alt wc-forward']"));
    }
}
