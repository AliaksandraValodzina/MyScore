using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LogInTest.Pages.MatchPages.Sections.LiveCentreSections
{
    public partial class LiveCentreSection : BasePage
    {
        /// <summary>
        /// Statistic Tab element.
        /// </summary>
        /*[FindsBy(How = How.CssSelector, Using = "#a-match-statistics")]
        public IWebElement StatisticTab { get; set; }*/
        public IWebElement StatisticTab => driver.FindElement(By.CssSelector("#a-match-statistics"));
    }
}
