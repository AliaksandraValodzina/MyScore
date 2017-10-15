using System.Linq;
using LogInTest.Pages.MatchPages;

namespace LogInTest.Pages.SignUpPage
{
    public partial class MyScoreSoccerPage : BasePage
    {
        public MatchPage NavigateToTheMatch(string commandName)
        {
            return HomeTeamNames.FirstOrDefault(x => x.Text.Equals(commandName)).Click<MatchPage>();
        }

        public void SelectAllMatchesOnThePage()
        {
            LeagueCheckbox.ToList().ForEach(x => x.Click());
        }
    }
}
