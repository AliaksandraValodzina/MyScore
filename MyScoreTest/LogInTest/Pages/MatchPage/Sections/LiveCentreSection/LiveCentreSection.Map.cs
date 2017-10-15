using OpenQA.Selenium;
using System.Collections.Generic;

namespace LogInTest.Pages.Sections.ConnectWithSection
{
    public partial class LiveCentreSection
    {
        /// <summary>
        /// Statistic Tab element.
        /// </summary>
        public IWebElement StatisticTab => driver.FindElement(By.Id("a-match-statistics"));
    }
}
