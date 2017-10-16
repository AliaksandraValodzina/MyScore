using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace LogInTest.Pages.MatchPages.Sections.StatisticSections
{
    public partial class MatchReviewSection : BasePage
    {
        #region Before match elements

        /// <summary>
        /// Missing Players Names Home element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#missing-players .fl .name a")]
        public IList<IWebElement> MissingPlayersNamesHome { get; set; }

        /// <summary>
        /// Missing Players Names Away element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#missing-players .fr .name a")]
        public IList<IWebElement> MissingPlayersNamesAway { get; set; }
        
        #endregion
    }
}
