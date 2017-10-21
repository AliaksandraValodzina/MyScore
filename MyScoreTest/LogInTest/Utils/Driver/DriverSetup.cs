using OpenQA.Selenium;
using Microsoft.Practices.Unity;
using System;
using OpenQA.Selenium.Chrome;
using LogInTest.Utils.Common;

namespace LogInTest.Utils.Driver
{
    public class DriverSetup
    {
        private static DriverSetup instance = null;

        private IWebDriver driver;

        public DriverSetup()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\Volodin\Documents\Visual Studio 2015\Projects\MyScoreProgects\MyScore\MyScoreTest\packages", "chromedriver.exe");
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


        public T GetPage<T>(IWebDriver Driver = null)
        {
            try
            {
                return Base.Container.Resolve<T>();
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error Resolving page - Check the app.config is set to the correct locale.");
                return (T)Activator.CreateInstance(typeof(T), Driver);
            }
        }
    }
}
