using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using LogInTest.Pages.SignUpPage;
using System.Linq;
using LogInTest.Enum;
using LogInTest.Pages.MatchPage;

namespace LogInTest
{
    [TestClass]
    public class LoginTests
    {
        private IWebDriver driver;
        private MyScoreSoccerPage MyScoreSoccerPage;

        [TestInitialize]
        public void TestInitialize()
        {
            MyScoreSoccerPage = new MyScoreSoccerPage();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            MyScoreSoccerPage.Quit();
        }

        [TestMethod]
        public void GetShotsForCommandMatch()
        {
            MyScoreSoccerPage.Navigate();
            MyScoreSoccerPage.NavigateToTheMatch("Брешия (Ж)");
            MyScoreSoccerPage.SwitchToLast();

            MatchPage matchPage = new MatchPage(driver);
            var statisticSection = matchPage.LiveCentreSection.ClickToStatisticTab();
            var shotsHome = statisticSection.GetShotsOnGoalText(CommandType.Home);
            var shotsAway = statisticSection.GetShotsOnGoalText(CommandType.Away);
            Console.WriteLine(shotsHome);
        }

        [TestMethod]
        public void SelectAllCheckboxes()
        {
            var signUpPage = new MyScoreSoccerPage();
            signUpPage.Navigate();
            signUpPage.LiveTub.Click();
            signUpPage.SelectAllMatchesOnThePage();
        }

        [TestMethod]
        public void GetCoef()
        {
            var name = "Эйбар";
            var signUpPage = new MyScoreSoccerPage();
            signUpPage.Navigate();
            signUpPage.NavigateToTheMatch(name);
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            MatchPage matchPage = new MatchPage(driver);
            var x1 = matchPage.LiveCentreSection.MatchReviewSection.DifferenceInLossesOfLeadingPlayers();

            var tableTub = matchPage.ClickToTableTab();
            tableTub.X2(name);
        }
    }
}
