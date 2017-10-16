using LogInTest.Pages.MatchPages.Sections.StatisticSections;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LogInTest.Pages.MatchPages.Sections.LiveCentreSections
{
    /// <summary>
    /// LiveCentre Section.
    /// </summary>
    public partial class LiveCentreSection : BasePage
    {
        /// <summary>
        /// LiveCentreSection constructor.
        /// </summary>
        public LiveCentreSection(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
            MatchReviewSection = new MatchReviewSection(driver);
        }

        public MatchReviewSection MatchReviewSection { get; private set; }

        /// <summary>
        /// Navigate to statistic tab.
        /// </summary>
        public StatisticSection ClickToStatisticTab()
        {
            StatisticTab.Click();
            return new StatisticSection(driver);
        }
    }
}
