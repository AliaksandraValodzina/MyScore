﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LogInTest.Pages.MatchPages
{
    public partial class MatchPage : BasePage
    {
        /// <summary>
        /// Table Tab element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#a-match-standings")]
        public IWebElement TableTab { get; set; }

        /// <summary>
        /// Coefs Tab element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#a-match-odds-comparison")]
        public IWebElement CoefTab { get; set; }

        /// <summary>
        /// Home Team Name element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = ".tname-home span a")]
        public IWebElement HomeTeamName { get; set; }

        /// <summary>
        /// Away Team Name element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = ".tname-away span a")]
        public IWebElement AwayTeamName { get; set; }

        /// <summary>
        /// Clock element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#atomclock")]
        public IWebElement Clock { get; set; }
    }
}
