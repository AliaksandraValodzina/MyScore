using LogInTest.Pages.Sections.ConnectWithSection;
using OpenQA.Selenium;

namespace LogInTest.Pages.LoginPage
{
    public partial class MatchPage
    {
        private readonly IWebDriver driver;

        public MatchPage(IWebDriver browser)
        {
            driver = browser;
            LiveCentreSection = new LiveCentreSection(driver);
        }

        public LiveCentreSection LiveCentreSection { get; private set; }
    }
}
