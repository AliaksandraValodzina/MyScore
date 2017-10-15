using OpenQA.Selenium;
using System.Linq;

namespace LogInTest.Pages.SignUpPage
{
    public partial class MyScoreSoccerPage : BasePage
    {
        public void NavigateToTheMatch(string commandName)
        {
            HomeTeamNames.FirstOrDefault(x => x.Text.Equals(commandName)).Click();
        }

        public void SelectAllMatchesOnThePage()
        {
            LeagueCheckbox.ToList().ForEach(x => x.Click());
        }
    }
}
