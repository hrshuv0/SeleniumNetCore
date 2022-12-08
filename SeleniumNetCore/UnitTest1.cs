using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNetCore.Pages;

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
    public void Test()
    {
        Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

        //// set input field text
        //// Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

        //CustomControl.EnterText(Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Tomato");

        //// Click on ckeckbox - with no id
        //// Driver.FindElement(by: By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

        //CustomControl.Click(Driver.FindElement(by: By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")));

        CustomControl.SelectByText(Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Cauliflower");
        
        CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

        

        Console.WriteLine("Test1");
        Assert.Pass();
    }

    [Test]
    public void LoginTest()
    {
        Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

        HomePage homePage = new HomePage();
        LoginPage loginPage = new LoginPage();

        homePage.ClickLogin();
        loginPage.EnterUsernameAndPassword("admin", "password");
        loginPage.ClickLogin();
        
        Assert.That(homePage.IsLogOffExists(), Is.True, "Log off button did not displayed");

    }
}