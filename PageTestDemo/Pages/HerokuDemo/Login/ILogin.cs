using PageTestDemo.Pages.HerokuDemo.SecureArea;

namespace PageTestDemo.Pages.HerokuDemo.Login
{
    interface ILogin
    {
        LoginPage EnterUserName(string username);

        LoginPage EnterPassword(string password);

        SecureAreaPage ClickLoginButton();
    }
}
