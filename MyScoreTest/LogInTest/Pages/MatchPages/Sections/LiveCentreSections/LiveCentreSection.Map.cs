using OpenQA.Selenium;

namespace LogInTest.Pages.MatchPages.Sections.LiveCentreSections
{
    public partial class LiveCentreSection : BasePage
    {
        /// <summary>
        /// Statistic Tab element.
        /// </summary>
        public IWebElement StatisticTab => driver.FindElement(By.Id("a-match-statistics"));
    }
}
