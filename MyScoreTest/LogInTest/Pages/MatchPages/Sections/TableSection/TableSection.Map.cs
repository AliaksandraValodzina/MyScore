using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace LogInTest.Pages.MatchPages.Sections.TableSection
{
    public partial class TableSection
    {
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
        /// Table Row element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = ".stats-table-container tbody tr")]
        public IList<IWebElement> TableRows { get; set; }

        // participant_name
    }
}
