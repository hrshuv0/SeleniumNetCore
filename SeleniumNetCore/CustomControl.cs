using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumNetCore;

public class CustomControl : DriverHelper
{
    public static void ComboBox(string controlName, string value)
    {
        IWebElement comboControll = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
        comboControll.Clear();
        comboControll.SendKeys(value);
        Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
    }


    public static void EnterText(IWebElement webElement, string value) => webElement.SendKeys(value);

    public static void Click(IWebElement webElement) => webElement.Click();

    public static void SelectByValue(IWebElement webElement, string value)
    {
        SelectElement selectElement = new SelectElement(webElement);
        selectElement.SelectByValue(value);
    }

    public static void SelectByText(IWebElement webElement, string text)
    {
        SelectElement selectElement = new SelectElement(webElement);
        selectElement.SelectByText(text);
    }
}
