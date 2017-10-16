using OpenQA.Selenium;
using System.Linq;

namespace LogInTest.Pages.MatchPages.Sections.TableSection
{
    public partial class TableSection
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// TableSection constructor.
        /// </summary>
        public TableSection(IWebDriver browser)
        {
            driver = browser;
        }

        /// <summary>
        /// Navigate to statistic tab.
        /// </summary>
        public int X2(string name)
        {
            var r = TableRows.ToList();
            var rr = r.Select(x => x.FindElement(By.CssSelector(".team_name_span a")));
            var row = rr.First(x => x.Text.Equals(name));
            var list = row.FindElements(By.CssSelector(".form-bg"));

            return 1;
        }
    }
}
