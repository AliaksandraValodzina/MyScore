using OpenQA.Selenium;
using System.Collections.Generic;

namespace LogInTest.Pages.SignUpPage
{
    public partial class MyScoreSoccerPage : BasePage
    {
        public IWebElement LiveTub => driver.FindElement(By.CssSelector(".ifmenu-live"));

        public IList<IWebElement> LeagueListsNames => driver.FindElements(By.CssSelector(".table-main .soccer thead .tournament_part"));

        public IList<IWebElement> HomeTeamNames => driver.FindElements(By.CssSelector(".table-main .soccer tbody .team-home"));

        public IList<IWebElement> AwayTeamNames => driver.FindElements(By.CssSelector(".table-main .soccer tbody .team-away"));

        public IList<IWebElement> LeagueCheckbox => driver.FindElements(By.CssSelector(".head_aa .icons span"));
    }
}
