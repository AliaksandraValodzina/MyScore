using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace LogInTest.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        private readonly string url = @"http://www.myscore.com.ua/";

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void Navigate() => driver.Navigate().GoToUrl(url);

        public void Quit() => driver.Quit();

        public void SwitchToLast()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public BasePage SwitchToLastAndClose()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Close();
            SwitchToLast();
            return this;
        }
    }
}
