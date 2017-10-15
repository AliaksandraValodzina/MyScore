using LogInTest.Pages.MatchPage.Sections.StatisticSection;
using OpenQA.Selenium;

namespace LogInTest.Pages.Sections.ConnectWithSection
{
    /// <summary>
    /// LiveCentre Section.
    /// </summary>
    public partial class LiveCentreSection : BasePage
    {
        /// <summary>
        /// LiveCentreSection constructor.
        /// </summary>
        public LiveCentreSection()
        {
            MatchReviewSection = new MatchReviewSection();
        }

        public MatchReviewSection MatchReviewSection { get; private set; }

        /// <summary>
        /// Navigate to statistic tab.
        /// </summary>
        public StatisticSection ClickToStatisticTab()
        {
            StatisticTab.Click();
            return new StatisticSection();
        }
    }
}
