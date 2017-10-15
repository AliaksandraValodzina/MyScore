using OpenQA.Selenium;
using System.Linq;

namespace LogInTest.Pages.MatchPage.Sections.StatisticSection
{
    public partial class MatchReviewSection
    {
        private readonly IWebDriver driver;

        public MatchReviewSection(IWebDriver browser)
        {
            driver = browser;
        }

        /// <summary>
        /// Get difference in losses of leading players.
        /// X1
        /// </summary>
        /// <returns>The difference in losses of leading players.</returns>
        public int DifferenceInLossesOfLeadingPlayers()
        {
            var homeMissingPlayers = MissingPlayersNamesHome.ToList();
            var awayMissingPlayers = MissingPlayersNamesAway.ToList();
            var difference = homeMissingPlayers.Count() - awayMissingPlayers.Count();

            return difference;
        }
    }
}
