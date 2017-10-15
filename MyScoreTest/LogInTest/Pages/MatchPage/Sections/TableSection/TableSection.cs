using OpenQA.Selenium;
using LogInTest.Pages.MatchPage.Sections.TableSection.CommandRowSection;

namespace LogInTest.Pages.MatchPage.Sections.TableSection
{
    public partial class TableSection
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// LiveCentreSection constructor.
        /// </summary>
        public TableSection(IWebDriver browser)
        {
            driver = browser;
            CommandRow = new CommandRow(driver);
        }

        public CommandRow CommandRow { get; private set; }
    }
}
