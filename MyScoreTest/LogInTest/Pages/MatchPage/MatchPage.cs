using LogInTest.Pages.MatchPage.Sections.TableSection;
using LogInTest.Pages.Sections.ConnectWithSection;
using OpenQA.Selenium;

namespace LogInTest.Pages.MatchPage
{
    public partial class MatchPage : BasePage
    {
        public MatchPage(IWebDriver browser)
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
