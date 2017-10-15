using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogInTest.Pages.Sections.ConnectWithSection
{
    public partial class LiveCentreSection
    {
        /// <summary>
        /// Check that static tab is visible
        /// </summary>
        public void IsStatisticTabVisible() => Assert.IsTrue(StatisticTab.Displayed);
    }
}
