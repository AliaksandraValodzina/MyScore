using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogInTest.Pages.MatchPages.Sections.LiveCentreSections
{
    public partial class LiveCentreSection : BasePage
    {
        /// <summary>
        /// Check that static tab is visible
        /// </summary>
        public void IsStatisticTabVisible() => Assert.IsTrue(StatisticTab.Displayed);
    }
}
