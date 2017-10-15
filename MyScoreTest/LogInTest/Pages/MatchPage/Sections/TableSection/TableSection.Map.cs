using LogInTest.Pages.MatchPage.Sections.TableSection.CommandRowSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInTest.Pages.MatchPage.Sections.TableSection
{
    public partial class TableSection
    {
        /// <summary>
        /// Statistic Tab element.
        /// </summary>
        public IList<CommandRow> StatisticTab => driver.FindElement(By.Id(".stats-table tbody tr"));
    }
}
