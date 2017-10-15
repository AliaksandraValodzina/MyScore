using LogInTest.Pages.MatchPage.Sections.StatisticSection;
using OpenQA.Selenium;

namespace LogInTest.Pages.Sections.ConnectWithSection
{
    /// <summary>
    /// LiveCentre Section.
    /// </summary>
    public partial class LiveCentreSection
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// LiveCentreSection constructor.
        /// </summary>
        public LiveCentreSection(IWebDriver browser)
        {
            driver = browser;
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
