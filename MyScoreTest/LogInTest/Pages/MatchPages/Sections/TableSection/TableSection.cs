using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Linq;

namespace LogInTest.Pages.MatchPages.Sections.TableSection
{
    public partial class TableSection : BasePage
    {
        public TableSection(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Points Total In 5 Previous Mathes.
        /// </summary>
        public int PointsTotalIn5Mathes(string name)
        {
            var rows = TableRows.ToList();
            var row = rows.First(x => x.FindElement(By.CssSelector(".team_name_span a")).Text.Contains(name));
            var games = row.FindElements(By.CssSelector(".col_form div a"))
                .Select(x => x.GetAttribute("title")).ToList();
            int points = 0;

            foreach (var prevGame in games)
            {
                string[] separatingChars = { "[b]", ":", "&nbsp;[/b](", "-", ")\r\n" };

                string[] words = prevGame
                    .Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);

                if (!words.Length.Equals(3))
                {
                    if (words.ElementAt(2).Trim().Equals(name))
                    {
                        if (Int32.Parse(words.ElementAt(0)) > Int32.Parse(words.ElementAt(1)))
                        {
                            points = points + 3;
                        }
                        if (Int32.Parse(words.ElementAt(0)) == Int32.Parse(words.ElementAt(1)))
                        {
                            points = points + 1;
                        }
                    }
                    if (words.ElementAt(3).Trim().Equals(name))
                    {
                        if (Int32.Parse(words.ElementAt(0)) < Int32.Parse(words.ElementAt(1)))
                        {
                            points = points + 3;
                        }
                        if (Int32.Parse(words.ElementAt(0)) == Int32.Parse(words.ElementAt(1)))
                        {
                            points = points + 1;
                        }
                    }
                }
            }

            return points;
        }

        /// <summary>
        /// X2 coef.
        /// </summary>
        public int X2()
        {
            var homePoints = PointsTotalIn5Mathes(HomeTeamName.Text.Trim());
            var awayPoints = PointsTotalIn5Mathes(AwayTeamName.Text.Trim());
            var x2 = homePoints - awayPoints;

            return x2;
        }

        /// <summary>
        /// X3 coef.
        /// </summary>
        public int X3()
        {
            var homeRank = CommandRank(HomeTeamName.Text.Trim());
            var awayRank = CommandRank(AwayTeamName.Text.Trim());
            var x3 = homeRank - awayRank;

            return x3;
        }

        /// <summary>
        /// Command Rank.
        /// </summary>
        public int CommandRank(string name)
        {
            var rows = TableRows.ToList();
            var row = rows.First(x => x.FindElement(By.CssSelector(".team_name_span a")).Text.Contains(name));
            var rank = row.FindElement(By.CssSelector(".rank")).Text.Trim('.');

            return Int32.Parse(rank);
        }

        /// <summary>
        /// X4 coef.
        /// </summary>
        public decimal X4()
        {
            HomeSubtub.Click();
            var homeTotalPoints = TotalPoints(HomeTeamName.Text.Trim());
            var homeGamesNumber = GamesNumber(HomeTeamName.Text.Trim());

            AwaySubtub.Click();
            var awayTotalPoints = TotalPoints(AwayTeamName.Text.Trim());
            var awayGamesNumber = GamesNumber(AwayTeamName.Text.Trim());

            var x4 = homeTotalPoints/homeGamesNumber - awayTotalPoints/awayGamesNumber;

            return x4;
        }

        /// <summary>
        /// Total Points.
        /// </summary>
        public decimal TotalPoints(string name)
        {
            // var rows = TableRows;
            wait.Until(drv => drv.FindElements(By.CssSelector(".stats-table-container tbody tr")).Any(x => x.Enabled));
            var rows = driver.FindElements(By.CssSelector(".stats-table-container .team_name_span a"));
            var row = rows.First(y => y.Enabled && y.Text.Contains(name));
            var points = row.FindElements(By.CssSelector(".goals"))[1].Text;

            return Decimal.Parse(points);
        }

        /// <summary>
        /// Games Number.
        /// </summary>
        public decimal GamesNumber(string name)
        {
            var row = driver.FindElements(By.CssSelector(".stats-table-container tbody tr")).First(y => y.Text.Contains(name));
            var points = row.FindElement(By.CssSelector(".matches_played")).Text;

            return Decimal.Parse(points);
        }

        /// <summary>
        /// X5 coef.
        /// </summary>
        public decimal X5()
        {
            HomeSubtub.Click();
            var homeDifferenceGoals = DifferenceScoredAndMissedGoals(HomeTeamName.Text.Trim());

            AwaySubtub.Click();
            var awayDifferenceGoals = DifferenceScoredAndMissedGoals(AwayTeamName.Text.Trim());

            var x5 = homeDifferenceGoals + awayDifferenceGoals;

            return x5;
        }

        /// <summary>
        /// Games Number.
        /// </summary>
        public int DifferenceScoredAndMissedGoals(string name)
        {
            var rows = TableRows.ToList();
            var row = rows.First(x => x.FindElement(By.CssSelector(".team_name_span a")).Text.Equals(name));
            var points = row.FindElements(By.CssSelector(".goals"))[0].Text.Split(':');

            return Int32.Parse(points[0]) - Int32.Parse(points[1]);
        }
    }
}
