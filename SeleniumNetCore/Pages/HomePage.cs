using OpenQA.Selenium;

namespace SeleniumNetCore.Pages;

public class HomePage : DriverHelper
{
    IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
    IWebElement lnkLogOff => Driver.FindElement(By.LinkText("Log off"));

    public void ClickLogin() => lnkLogin.Click();


    public bool IsLogOffExists() => lnkLogOff.Displayed;
}
