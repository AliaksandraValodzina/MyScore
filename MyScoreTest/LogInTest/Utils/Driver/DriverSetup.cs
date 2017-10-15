using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace LogInTest.Utils.Driver
{
    public class DriverSetup
    {
        private static DriverSetup instance = null;

        private IWebDriver driver;

        public DriverSetup()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\Volodin\Documents\Visual Studio 2015\Projects\MyScoreProgects\MyScoreTest\packages", "chromedriver.exe");
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public static DriverSetup getInstance()
        {
            if (instance == null)
            {
                instance = new DriverSetup();
            }
            return instance;
        }

        public IWebDriver getDriver()
        {
            return driver;
        }

    }
}
