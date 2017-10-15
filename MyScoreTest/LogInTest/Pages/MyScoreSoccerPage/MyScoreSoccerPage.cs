using System.Linq;
using LogInTest.Pages.MatchPages;
using OpenQA.Selenium;

namespace LogInTest.Pages.SignUpPage
{
    public partial class MyScoreSoccerPage : BasePage
    {
        public MyScoreSoccerPage(IWebDriver driver) : base(driver) { }

        public MatchPage NavigateToTheMatch(string commandName)
        {
            HomeTeamNames.FirstOrDefault(x => x.Text.Equals(commandName)).Click();
            return new MatchPage();
        }

        public void SelectAllMatchesOnThePage()
        {
            LeagueCheckbox.ToList().ForEach(x => x.Click());
        }
    }
}
