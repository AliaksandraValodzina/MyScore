using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInTest.Pages.MatchPage.Sections.StatisticSection
{
    public partial class MatchReviewSection
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
