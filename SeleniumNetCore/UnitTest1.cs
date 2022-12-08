using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumNetCore
{
    public class Tests
    {
        public IWebDriver Driver;

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

            IWebElement comboControll = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
            comboControll.Clear();
            comboControll.SendKeys("Almond");
            Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();

            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}