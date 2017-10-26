using LogInTest.Pages.MatchPages.Sections.LiveCentreSections;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LogInTest.Pages.MatchPages
{
    public partial class MatchPage : BasePage
    {
        public MatchPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
            LiveCentreSection = new LiveCentreSection(driver);
        }

        public LiveCentreSection LiveCentreSection { get; private set; }
    }
}
