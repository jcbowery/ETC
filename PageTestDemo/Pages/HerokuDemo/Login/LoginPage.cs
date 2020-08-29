using PageTestDemo.Pages.Base;
using PageTestDemo.Pages.HerokuDemo.SecureArea;

namespace PageTestDemo.Pages.HerokuDemo.Login
{
    public partial class LoginPage : Page<LoginPage>, ILogin
    {

        public SecureAreaPage ClickLoginButton()
        {
            LoginButton.Click(); 
            return new SecureAreaPage();
        }

        public LoginPage EnterPassword(string password)
        {
            Password.SendKeys(password); 
            return this;
        }

        public LoginPage EnterUserName(string username)
        {
            UserName.SendKeys(username);
            return this;
        }


    }
}
