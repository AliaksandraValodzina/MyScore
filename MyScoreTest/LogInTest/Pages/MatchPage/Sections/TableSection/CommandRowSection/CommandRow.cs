using OpenQA.Selenium;

namespace LogInTest.Pages.MatchPage.Sections.TableSection.CommandRowSection
{
    public partial class CommandRow : IWebElement
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// CommandRow constructor.
        /// </summary>
        public CommandRow(IWebDriver browser)
        {
            driver = browser;
        }
    }
}
