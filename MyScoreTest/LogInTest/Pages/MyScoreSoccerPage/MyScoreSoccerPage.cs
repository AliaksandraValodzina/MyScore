using System.Linq;
using LogInTest.Pages.MatchPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LogInTest.Pages.SignUpPage
{
    public partial class MyScoreSoccerPage : BasePage
    {
        public MyScoreSoccerPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public MatchPage NavigateToTheMatch(string commandName)
        {
            return HomeTeamNames.FirstOrDefault(x => x.GetText().Equals(commandName)).Click<MatchPage>();
        }

        public void SelectAllMatchesOnThePage()
        {
            LeagueCheckbox.ToList().ForEach(x => x.Click());
        }
    }
}
