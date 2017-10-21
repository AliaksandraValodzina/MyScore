using OpenQA.Selenium;
using System.Collections.Generic;

namespace LogInTest.Utils.Elements
{
    public interface IElement
    {
        /// <summary>
        /// Current WebDriver instance
        /// </summary>
        /*IWebDriver Driver { get; set; }

        /// <summary>
        /// By object for this element
        /// </summary>
        By By { get; set; }

        /// <summary>
        /// constructor using a by object
        /// </summary>
        /// <param name="driver">IWebDriver object</param>
        /// <param name="by">By object for this element</param>
        Element(IWebDriver driver, By by);

        /// <summary>
        /// Waits for this element to be displayed
        /// </summary>
        /// <param name="childSelector"></param>
        /// <param name="timeoutSeconds"></param>
        /// <returns></returns>
        bool HasChildElement(By childSelector, int timeoutSeconds = 0);

        /// <summary>
        /// WaitForElement will wait the specified number of seconds (default is 20) for an element to be found via the Driver
        /// </summary>
        /// <param name="Driver">the IWebDriver object</param>
        /// <param name="by">how to find the element</param>
        /// <param name="timeoutInSeconds">the length of time to wait</param>
        /// <param name="iterationDelaySeconds">Seconds to wait inbetween retrying</param>
        /// <returns>the WebElement if found</returns>
        /// <exception cref="NoSuchElementException">if the element is not found</exception>
        IWebElement WaitForElementExist(this IWebDriver Driver, By by, int timeoutInSeconds = 20, int iterationDelaySeconds = 2);

        /// <summary>
        /// Find elements within the current element.
        /// </summary>
        /// <returns>List of IWebElements.</returns>
        List<IWebElement> FindElements(By childSelector, int waitTimeInSeconds = 20);

        /// <summary>
        /// Find an element within the current element.
        /// </summary>
        /// <returns>IWebElement for this element's 'By'</returns>
        IWebElement FindElement(By childSelector, int waitTimeInSeconds = 20);

        /// <summary>
        /// Click
        /// </summary>
        void Click(int timeout = 20, bool waitAfterClick = true);

        /// <summary>
        /// Clicks the element and returns a new page
        /// </summary>
        /// <typeparam name="T">Type of page to return</typeparam>
        /// <returns>Page of Type T</returns>
        T Click<T>(int timeout = 20);

        /// <summary>
        /// Gets the text from the IWebEelement
        /// </summary>
        /// <returns>text property of the IWebElement</returns>
        string GetText(int timeoutSeconds = 20);*/
    }
}