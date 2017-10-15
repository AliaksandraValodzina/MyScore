using LogInTest.Pages.MatchPages.Sections.LiveCentreSections;
using LogInTest.Pages.MatchPages.Sections.TableSection;

namespace LogInTest.Pages.MatchPages
{
    public partial class MatchPage : BasePage
    {
        public MatchPage()
        {
            LiveCentreSection = new LiveCentreSection();
        }

        public LiveCentreSection LiveCentreSection { get; private set; }

        /// <summary>
        /// Navigate to table tab.
        /// </summary>
        public TableSection ClickToTableTab()
        {
            TableTab.Click();
            return new TableSection(driver);
        }
    }
}
