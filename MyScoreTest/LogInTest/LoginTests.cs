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

            MatchPage matchPage = new MatchPage();
            var statisticSection = matchPage.LiveCentreSection.ClickToStatisticTab();
            var shotsHome = statisticSection.GetShotsOnGoalText(CommandType.Home);
            var shotsAway = statisticSection.GetShotsOnGoalText(CommandType.Away);
            Console.WriteLine(shotsHome);
        }

        [TestMethod]
        public void SelectAllCheckboxes()
        {
            MyScoreSoccerPage.Navigate();
            MyScoreSoccerPage.LiveTub.Click();
            MyScoreSoccerPage.SwitchToLastAndClose();
            MyScoreSoccerPage.SelectAllMatchesOnThePage();
        }

        [TestMethod]
        public void GetCoef()
        {
            var name = "Брайтон";
            MyScoreSoccerPage.Navigate();
            MyScoreSoccerPage.NavigateToTheMatch(name);
            MatchPage matchPage = MyScoreSoccerPage.SwitchToLast();

            /*
            var x1 = matchPage.LiveCentreSection.MatchReviewSection.DifferenceInLossesOfLeadingPlayers();
            */

            var tableTub = matchPage.ClickToTableTab();
            tableTub.X2(name);
        }
    }
}
