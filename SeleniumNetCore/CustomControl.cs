using OpenQA.Selenium;

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
}
