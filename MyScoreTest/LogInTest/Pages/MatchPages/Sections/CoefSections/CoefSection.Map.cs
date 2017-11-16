using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace LogInTest.Pages.MatchPages.Sections.LiveCentreSections
{
    public partial class CoefSection : BasePage
    {
        /// <summary>
        /// Statistic Tab element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#bookmark-1x2 span a")]
        public IWebElement OneXTwoTub { get; set; }

        /// <summary>
        /// oneXTwo coef element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = ".odd .odds-wrap")]
        public IList<IWebElement> OneXTwoCoefs { get; set; }

        /// <summary>
        /// Handicap Tab element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#bookmark-asian-handicap")]
        public IWebElement HandicapTub { get; set; }

        /// <summary>
        /// Handicap 0.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#odds_ah_0  .odds-wrap")]
        public IList<IWebElement> HandicapNull { get; set; }

        /// <summary>
        /// Handicap -1.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#odds_ah_-1  .odds-wrap")]
        public IList<IWebElement> HandicapMinusOne { get; set; }

        /// <summary>
        /// Handicap 1.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "#odds_ah_1 .odds-wrap")]
        public IList<IWebElement> HandicapPlusOne { get; set; }
    }
}
