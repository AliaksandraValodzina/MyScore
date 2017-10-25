﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;

namespace LogInTest.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;

        private readonly string url = @"http://www.myscore.com.ua/";

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
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
