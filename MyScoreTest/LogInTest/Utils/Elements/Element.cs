using LogInTest.Utils.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;

namespace LogInTest.Utils.Elements
{
    public class Element
    {
        /// <summary>
        /// Current WebDriver instance
        /// </summary>
        protected IWebDriver Driver { get; private set; }

        /// <summary>
        /// By object for this element
        /// </summary>
        public By By { get; set; }

        /// <summary>
        /// constructor using a by object
        /// </summary>
        /// <param name="driver">IWebDriver object</param>
        /// <param name="by">By object for this element</param>
        public Element(IWebDriver driver, By by)
        {
            Driver = driver;
            By = by;
        }

        /// <summary>
        /// Waits for this element to be displayed
        /// </summary>
        /// <param name="childSelector"></param>
        /// <param name="timeoutSeconds"></param>
        /// <returns></returns>
        public bool HasChildElement(By childSelector, int timeoutSeconds = 0)
        {
            // IsDisplayed();

            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutSeconds));
                wait.Until(d => FindElements(childSelector).Count > 0);
                return true;
            }
            catch
            {
                Console.WriteLine("No child element with selector " + childSelector + " was found.");
                return false;
            }
        }

        /// <summary>
        /// WaitForElement will wait the specified number of seconds (default is 20) for an element to be found via the Driver
        /// </summary>
        /// <param name="Driver">the IWebDriver object</param>
        /// <param name="by">how to find the element</param>
        /// <param name="timeoutInSeconds">the length of time to wait</param>
        /// <param name="iterationDelaySeconds">Seconds to wait inbetween retrying</param>
        /// <returns>the WebElement if found</returns>
        /// <exception cref="NoSuchElementException">if the element is not found</exception>
        public IWebElement WaitForElementExist(this IWebDriver Driver, By by, int timeoutInSeconds = 20, int iterationDelaySeconds = 2)
        {
            try
            {
                if (timeoutInSeconds > 0)
                {
                    var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                    wait.Until(drv => drv.FindElement(by));
                }
            }
            catch
            {
                Console.WriteLine("Timed out waiting for element with selector: " + by);
            }

            return Driver.FindElement(by);
        }

        /// <summary>
        /// Find elements within the current element.
        /// </summary>
        /// <returns>List of IWebElements.</returns>
        public List<IWebElement> FindElements(By childSelector, int waitTimeInSeconds = 20)
        {
            var currentElement = WaitForElementExist(Driver, By, waitTimeInSeconds);
            var elements = currentElement.FindElements(childSelector);
            return new List<IWebElement>(elements);
        }

        /// <summary>
        /// Find an element within the current element.
        /// </summary>
        /// <returns>IWebElement for this element's 'By'</returns>
        public IWebElement FindElement(By childSelector, int waitTimeInSeconds = 20)
        {
            //Chain the current Element's by and the child by
            var element = WaitForElementExist(Driver, new ByChained(this.By, childSelector), waitTimeInSeconds);

            return element;
        }

        /// <summary>
        /// Click
        /// </summary>
        public void Click(int timeout = 20, bool waitAfterClick = true)
        {
            try
            {
                var element = Driver.FindElement(By);

                var clickAction = new Actions(Driver).MoveToElement(element).Click().Build();
                clickAction.Perform();
            }
            catch
            {
                Console.WriteLine("Error clicking element.");
            }

            if (waitAfterClick)
            {
                WaitForElementExist(Driver, By, timeout);
            }
        }

        /// <summary>
        /// Clicks the element and returns a new page
        /// </summary>
        /// <typeparam name="T">Type of page to return</typeparam>
        /// <returns>Page of Type T</returns>
        public T Click<T>(int timeout = 20)
        {
            Click(timeout);
            return DriverSetup.getInstance().GetPage<T>(Driver);
        }

        /// <summary>
        /// Gets the text from the IWebEelement
        /// </summary>
        /// <returns>text property of the IWebElement</returns>
        public string GetText(int timeoutSeconds = 20)
        {
            return WaitForElementExist(Driver, By, timeoutSeconds).Text.Trim();
        }
    }
}