using PageTestDemo.Pages.BellatrixDemo.Cart;

namespace PageTestDemo.Pages.BellatrixDemo.Home
{
    public partial class BellatrixDemoHome
    {
        public BellatrixDemoHome Falcon9_AddToCart()
        {
            Falcon9_AddToCartButton.Click();
            return this;
        }

        public CartPage Falcon9_ViewCart()
        {
            Falcon9_ViewCartButton.Click();
            return new CartPage();
        }
    }
}
