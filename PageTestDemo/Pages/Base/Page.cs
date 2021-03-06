﻿using Selenium;

namespace PageTestDemo.Pages.Base
{
    public class Page<T> where T : Page<T>
    {
        string URL;
        public virtual T Navigate(string url)
        {

            Driver.GoToUrl(url);
            return (T)this;

        }
       
    }
}
