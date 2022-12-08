using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumNetCore;

public class Tests : DriverHelper
{
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("Setup");

        ChromeOptions chromeOptions = new ChromeOptions();

        Driver = new ChromeDriver();
    }

    [Test]
    public void Test1()
    {
        Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

        // Set input field text
        Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

        // Click on ckeckbox - with no id
        Driver.FindElement(by: By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

        CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

        

        Console.WriteLine("Test1");
        Assert.Pass();
    }
}