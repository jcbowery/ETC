using Logging;
using OpenQA.Selenium.Support.Events;

namespace Selenium
{
    public static partial class Driver
    {
        private static void FiringDriver_Looked(object sender, FindElementEventArgs e)
        {
            LogHelper.Log?.Info($"Found Element");
        }

        private static void FiringDriver_Looking(object sender, FindElementEventArgs e)
        {
            LogHelper.Log?.Step($"Looking for Element {e.FindMethod}");
        }

        private static void FiringDriver_Navigated(object sender, WebDriverNavigationEventArgs e)
        {
            LogHelper.Log?.Info($"{e.Url} Loaded ");
        }

        private static void FiringDriver_Navigating(object sender, WebDriverNavigationEventArgs e)
        {
            LogHelper.Log?.Step($"Navigating to: {e.Url}");
        }
        private static void Exception_Thrown(object sender, WebDriverExceptionEventArgs e)
        {
            LogHelper.Log?.Error("Exception thrown was : " + e.ThrownException);
        }

        private static void Element_Changed(object sender, WebElementValueEventArgs e)
        {
            LogHelper.Log?.Info($"TEXT SENT");
        }

        private static void Element_Changing(object sender, WebElementValueEventArgs e)
        {
            LogHelper.Log?.Step($"Sending \"{ e.Value}\" to element");
        }

        private static void Clicked_Element(object sender, WebElementEventArgs e)
        {
            LogHelper.Log?.Info($"Clicked on Element");

        }

        private static void Clicking_Element(object sender, WebElementEventArgs e)
        {
            LogHelper.Log?.Step("Clicking on Element : " + e.Element.Text);
        }
    }
}
