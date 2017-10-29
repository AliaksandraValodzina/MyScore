using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;

namespace LogInTest.Pages.MatchPages.Sections.StatisticSections
{
    public partial class MatchReviewSection : BasePage
    {
        public MatchReviewSection(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Get difference in losses of leading players.
        /// X1
        /// </summary>
        /// <returns>The difference in losses of leading players.</returns>
        public int DifferenceInLossesOfLeadingPlayers()
        {
            var homeMissingPlayers = MissingPlayersNamesHome.Where(x => x.Enabled).ToList();
            var awayMissingPlayers = MissingPlayersNamesAway.Where(x => x.Enabled).ToList();
            var difference = homeMissingPlayers.Count() - awayMissingPlayers.Count();

            return difference;
        }
    }
}
