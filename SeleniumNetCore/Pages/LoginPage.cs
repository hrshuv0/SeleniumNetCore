using OpenQA.Selenium;

namespace SeleniumNetCore.Pages;

public class LoginPage : DriverHelper
{
    IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));
    IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
    IWebElement btnLogin    => Driver.FindElement(By.CssSelector(".btn-default"));

    public void EnterUsernameAndPassword(string userName, string password)
    {
        txtUserName.SendKeys(userName);
        txtPassword.SendKeys(password);
    }

    public void ClickLogin()
    {
        btnLogin.Click();
    }
}
