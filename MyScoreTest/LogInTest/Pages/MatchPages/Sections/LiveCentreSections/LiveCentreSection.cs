using LogInTest.Pages.MatchPages.Sections.StatisticSections;

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
