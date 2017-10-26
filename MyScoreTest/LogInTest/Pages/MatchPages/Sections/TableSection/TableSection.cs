using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
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
            var row = rows.First(x => x.FindElement(By.CssSelector(".team_name_span a")).Text.Equals(name));
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
            var homePoints = PointsTotalIn5Mathes(HomeTeamName.Text);
            var awayPoints = PointsTotalIn5Mathes(AwayTeamName.Text);
            var x2 = homePoints - awayPoints;

            return x2;
        }

        /// <summary>
        /// X3 coef.
        /// </summary>
        public int X3()
        {
            var homeRank = CommandRank(HomeTeamName.Text);
            var awayRank = CommandRank(AwayTeamName.Text);
            var x3 = homeRank - awayRank;

            return x3;
        }

        /// <summary>
        /// Command Rank.
        /// </summary>
        public int CommandRank(string name)
        {
            var rows = TableRows.ToList();
            var row = rows.First(x => x.FindElement(By.CssSelector(".team_name_span a")).Text.Equals(name));
            var rank = row.FindElement(By.CssSelector(".rank")).Text.Trim('.');

            return Int32.Parse(rank);
        }

    }
}
