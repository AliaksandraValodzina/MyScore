using OpenQA.Selenium;
using System.Collections.Generic;

namespace LogInTest.Pages.MatchPages.Sections.StatisticSections
{
    public partial class MatchReviewSection : BasePage
    {
        #region Before match elements

        /// <summary>
        /// Missing Players Names Home element.
        /// </summary>
        public IList<IWebElement> MissingPlayersNamesHome => driver.FindElements(By.CssSelector("#missing-players .fl .name a"));

        /// <summary>
        /// Missing Players Names Away element.
        /// </summary>
        public IList<IWebElement> MissingPlayersNamesAway => driver.FindElements(By.CssSelector("#missing-players .fr .name a"));
        #endregion
    }
}
