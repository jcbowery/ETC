using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PageTestDemo.Pages.BellatrixDemo.OrderReceived
{
    public partial class OrderReceivedPage
    {
        public OrderReceivedPage OrderWasReceived()
        {
            Assert.AreEqual("Thank you. Your order has been received.", OrderReceivedMessage.Text);
            return this;
        }
    }
}
