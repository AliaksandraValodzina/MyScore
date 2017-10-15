using OpenQA.Selenium;

namespace LogInTest.Pages.MatchPages
{
    public partial class MatchPage : BasePage
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
