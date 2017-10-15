using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace LogInTest.Pages.MatchPages.Sections.TableSection
{
    public partial class TableSection
    {
        /// <summary>
        /// Table Row element.
        /// </summary>
        public IList<IWebElement> TableRows => driver.FindElements(By.Id(".stats-table-container tbody tr"));
    }
}
