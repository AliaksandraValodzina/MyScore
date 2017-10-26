using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LogInTest.Pages.MatchPages.Sections.LiveCentreSections
{
    public partial class LiveCentreSection : BasePage
    {
        /// <summary>
        /// Statistic Tab element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#a-match-statistics")]
        public IWebElement StatisticTab { get; set; }

        /// <summary>
        /// LineUps Tab element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#a-match-lineups")]
        public IWebElement LineUpsTab { get; set; }
    }
}
