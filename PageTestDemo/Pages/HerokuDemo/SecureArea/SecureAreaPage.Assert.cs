using Asserts;

namespace PageTestDemo.Pages.HerokuDemo.SecureArea
{
    public partial class SecureAreaPage
    {
        public SecureAreaPage GreenToasterMessage(string message)
        {
            var x = Toaster.Text;
            Assert.AreEqual(message, Toaster.Text);
            return this;
        }
    }
}
