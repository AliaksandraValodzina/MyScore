using System.Linq;
using LogInTest.Pages.MatchPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using System.Collections.Generic;

namespace LogInTest.Pages.SignUpPage
{
    public partial class MyScoreSoccerPage : BasePage
    {
        public MyScoreSoccerPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void NavigateToTheMatch(string commandName)
        {
            wait.Until(x => x.FindElement(By.CssSelector("span.padr")));
            HomeTeamNames.FirstOrDefault(x => x.Text.Contains(commandName)).Click();
        }

        public void SelectAllMatchesOnThePage()
        {
            LeagueCheckbox.ToList().ForEach(x => x.Click());
        }

        /// <summary>
        /// List of home commands for the league.
        /// </summary>
        public IList<IWebElement> HomeCommandsForLeague(string league)
        {
            var leagues = LeagueTable;
            var row = leagues.First(x => x.FindElement(By.CssSelector("thead .tournament_part")).Text.Equals(league));
            var commands = row.FindElements(By.CssSelector("span.padr")).ToList();

            return commands;
        }
    }
}
