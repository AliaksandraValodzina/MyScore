﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace LogInTest.Pages.MatchPages.Sections.TableSection
{
    public partial class TableSection
    {
        /// <summary>
        /// Table Row element.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = ".stats-table-container tbody tr")]
        public IList<IWebElement> TableRows { get; set; }
    }
}
