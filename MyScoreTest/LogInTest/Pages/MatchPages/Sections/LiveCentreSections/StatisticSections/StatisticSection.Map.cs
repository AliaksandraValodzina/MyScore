using OpenQA.Selenium;

namespace LogInTest.Pages.MatchPages.Sections.StatisticSections
{
    public partial class StatisticSection : BasePage
    {
        /// <summary>
        /// Shots On Goal Home Element. 
        /// </summary>
        public IWebElement ShotsOnGoalHome => driver.FindElement(By.CssSelector("tbody tr:nth-of-type(3) .summary-vertical.fl div:nth-of-type(1)"));

        /// <summary>
        /// Shots On Goal Away Element. 
        /// </summary>
        public IWebElement ShotsOnGoalAway => driver.FindElement(By.CssSelector("tbody tr:nth-of-type(3) .summary-vertical.fr div:nth-of-type(2)"));
    }
}
