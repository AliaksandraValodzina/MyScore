using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInTest.Pages.MatchPage
{
    public partial class MatchPage
    {
        /// <summary>
        /// Table Tab element.
        /// </summary>
        public IWebElement TableTab => driver.FindElement(By.Id("a-match-standings"));

        /// <summary>
        /// Home Team Name element.
        /// </summary>
        public IWebElement HomeTeamName => driver.FindElement(By.CssSelector(".tname-home span a"));

        /// <summary>
        /// Away Team Name element.
        /// </summary>
        public IWebElement AwayTeamName => driver.FindElement(By.CssSelector(".tname-away span a"));
    }
}
