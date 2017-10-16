using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LogInTest.Pages.MatchPages.Sections.StatisticSections
{
    public partial class StatisticSection : BasePage
    {
        /// <summary>
        /// Shots On Goal Home Element. 
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "tbody tr:nth-of-type(3) .summary-vertical.fl div:nth-of-type(1)")]
        public IWebElement ShotsOnGoalHome { get; set; }

        /// <summary>
        /// Shots On Goal Away Element. 
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "tbody tr:nth-of-type(3) .summary-vertical.fr div:nth-of-type(2)")]
        public IWebElement ShotsOnGoalAway { get; set; }
    }
}
