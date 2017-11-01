using LogInTest.Utils.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace LogInTest.Pages.SignUpPage
{
    public partial class MyScoreSoccerPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".ifmenu-live")]
        public IWebElement LiveTub { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".table-main .soccer thead .tournament_part")]
        public IList<IWebElement> LeagueListsNames { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.padr")]
        public IList<IWebElement> HomeTeamNames { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".table-main .soccer tbody .team-away")]
        public IList<IWebElement> AwayTeamNames { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".head_aa .icons span")]
        public IList<IWebElement> LeagueCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ifmenu-calendar .yesterday")]
        public IWebElement PreviousDayArrow { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ifmenu-calendar .tomorrow")]
        public IWebElement NextDayArrow { get; set; }
    }
}
