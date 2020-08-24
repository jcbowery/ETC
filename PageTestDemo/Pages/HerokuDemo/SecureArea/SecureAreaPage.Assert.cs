using Asserts;

namespace PageTestDemo.Pages.HerokuDemo.SecureArea
{
    public partial class SecureAreaPage
    {
        public SecureAreaPage GreenToasterMessage(string message)
        {
            Assert.AreEqual(message, Toaster.Text);
            return this;
        }
    }
}
