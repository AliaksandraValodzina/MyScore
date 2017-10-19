﻿using LogInTest.Utils.Elements;
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

        [FindsBy(How = How.CssSelector, Using = ".table-main .soccer tbody .team-home")]
        public IList<Element> HomeTeamNames { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".table-main .soccer tbody .team-away")]
        public IList<IWebElement> AwayTeamNames { get; set; }

        public IList<IWebElement> LeagueCheckbox => driver.FindElements(By.CssSelector(".head_aa .icons span"));
    }
}
