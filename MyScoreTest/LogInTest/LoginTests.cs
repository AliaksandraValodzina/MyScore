using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using LogInTest.Pages.LoginPage;
using LogInTest.Pages.SignUpPage;
using OpenQA.Selenium.Chrome;
using System.Linq;
using LogInTest.Enum;

namespace LogInTest
{
    [TestClass]
    public class LoginTests
    {
        private IWebDriver driver;
        [TestInitialize]
        public void SetupTest()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\Volodin\Documents\Visual Studio 2015\Projects\LogInTest\packages", "chromedriver.exe");
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [TestMethod]
        public void GetShotsForCommandMatch()
        {
            var signUpPage = new MyScoreSoccerPage(driver);
            signUpPage.Navigate();
            signUpPage.NavigateToTheMatch("Брешия (Ж)");
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            MatchPage matchPage = new MatchPage(driver);
            var statisticSection = matchPage.LiveCentreSection.ClickToStatisticTab();
            var shotsHome = statisticSection.GetShotsOnGoalText(CommandType.Home);
            var shotsAway = statisticSection.GetShotsOnGoalText(CommandType.Away);
            Console.WriteLine(shotsHome);
        }

        [TestMethod]
        public void SelectAllCheckboxes()
        {
            var signUpPage = new MyScoreSoccerPage(driver);
            signUpPage.Navigate();
            signUpPage.LiveTub.Click();
            signUpPage.SelectAllMatchesOnThePage();
        }

        [TestMethod]
        public void GetCoef()
        {
            var signUpPage = new MyScoreSoccerPage(driver);
            signUpPage.Navigate();
            signUpPage.NavigateToTheMatch("Ливерпуль");
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            MatchPage matchPage = new MatchPage(driver);
            var x1 = matchPage.LiveCentreSection.MatchReviewSection.DifferenceInLossesOfLeadingPlayers();
        }
    }
}
