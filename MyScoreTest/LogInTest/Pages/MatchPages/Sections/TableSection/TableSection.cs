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
        /// Navigate to statistic tab.
        /// </summary>
        public int X2(string name)
        {
            var rows = TableRows.ToList();
            var row = rows.First(x => x.FindElement(By.CssSelector(".team_name_span a")).Text.Equals(name));
            var games = row.FindElements(By.CssSelector(".col_form div a"))
                .Select(x => x.GetAttribute("title")).ToList();
            int score = 0;

            foreach (var prevGame in games)
            {
                string[] separatingChars = { "[b]", ":", "&nbsp;[/b](", "-", ")\r\n" };

                string[] words = prevGame
                    .Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);

                if (words.Length.Equals(5))
                {
                    if (words.ElementAt(2).Trim().Equals(name))
                    {
                        if (Int32.Parse(words.ElementAt(0)) > Int32.Parse(words.ElementAt(1)))
                        {
                            score = score + 3;
                        } if (Int32.Parse(words.ElementAt(0)) == Int32.Parse(words.ElementAt(1)))
                        {
                            score = score + 1;
                        }
                    } if (words.ElementAt(3).Trim().Equals(name))
                    {
                        if (Int32.Parse(words.ElementAt(0)) < Int32.Parse(words.ElementAt(1)))
                        {
                            score = score + 3;
                        }
                        if (Int32.Parse(words.ElementAt(0)) == Int32.Parse(words.ElementAt(1)))
                        {
                            score = score + 1;
                        }
                    }
                }
            }

            /*var rr = r.ToList().Select(x => x.FindElement(By.CssSelector(".team_name_span a")));
            var row = rr.First(x => x.Text.Equals(name));
            var list = row.FindElements(By.CssSelector(".form-bg"))*/;

            return score;
        }
    }
}
