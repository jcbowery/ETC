using OpenQA.Selenium;
using Selenium;
using Selenium.Contracts;

namespace PageTestDemo.Pages.BellatrixDemo.Home
{
    public partial class BellatrixDemoHome
    {
        private IElement Falcon9_AddToCartButton => Driver.FindElement(By.XPath("//li[@class='product type-product post-28 status-publish first onbackorder product_cat-big-rockets has-post-thumbnail sale downloadable taxable shipping-taxable purchasable product-type-simple']//a[@class='button product_type_simple add_to_cart_button ajax_add_to_cart'][contains(text(),'Add to cart')]"));
        private IElement Falcon9_ViewCartButton => Driver.FindElement(By.XPath("//a[@class='added_to_cart wc-forward']"));
    }
}
