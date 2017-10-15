using OpenQA.Selenium;
using System.Linq;

namespace LogInTest.Pages.SignUpPage
{
    public partial class MyScoreSoccerPage
    {
        private readonly IWebDriver driver;
        private readonly string _url = @"http://www.myscore.com.ua/";

        public MyScoreSoccerPage(IWebDriver browser)
        {
            driver = browser;
        }

        public void Navigate() => driver.Navigate().GoToUrl(_url);

        public void NavigateToTheMatch(string commandName)
        {
            HomeTeamNames.FirstOrDefault(x => x.Text.Equals(commandName)).Click();
        }

        public void SelectAllMatchesOnThePage()
        {
            LeagueCheckbox.ToList().ForEach(x => x.Click());
        }
    }
}
