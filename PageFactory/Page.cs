using Selenium;

namespace PageFactory
{
    public class Page<T> where T : Page<T>
    {
        public virtual T Navigate(string url)
        {

            Driver.GoToUrl(url);
            return (T)this;

        }
    }
}
