using System;
using OpenQA.Selenium;
using LogInTest.Pages.SignUpPage;
using LogInTest.Enum;
using LogInTest.Pages.MatchPages;
using LogInTest.Utils.Driver;
using LogInTest.Pages.MatchPages.Sections.TableSection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FuzzyLogic;

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
            DriverSetup driverSetup = new DriverSetup();
            driver = driverSetup.getDriver();
            MyScoreSoccerPage = new MyScoreSoccerPage(driver);
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
            MyScoreSoccerPage.NavigateToTheMatch("Болонья");
            MatchPage matchPage = new MatchPage(driver);
            MyScoreSoccerPage.SwitchToLast();

            // MatchPage matchPage = new MatchPage(driver);
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
        public void GetCoefForTheMatch()
        {
            var name = "Лестер";
            MyScoreSoccerPage.Navigate();
            MyScoreSoccerPage.NavigateToTheMatch(name);

            if (MyScoreSoccerPage.LiveTub.Displayed)
            {
                MyScoreSoccerPage.SwitchToLast();
            }

            var matchPage = new MatchPage(driver);

            matchPage.LiveCentreSection.LineUpsTab.Click();
            
            var x1 = matchPage.LiveCentreSection.MatchReviewSection.DifferenceInLossesOfLeadingPlayers();

            matchPage.TableTab.Click();
            var tablePage = new TableSection(driver);
            var x2 = tablePage.X2();

            var x3 = tablePage.X3();

            var x4 = tablePage.X4();

            var x5 = tablePage.X5();

            LeagueScenarios scenarious = new LeagueScenarios();
            var result = scenarious.PremierLeague(x1, x2, x3, x4, x5);
        }

        [TestMethod]
        public void GetCoefForThePreviousMatch()
        {
            var name = "Бёрнли";
            MyScoreSoccerPage.Navigate();
            MyScoreSoccerPage.PreviousDayArrow.Click();
            MyScoreSoccerPage.NavigateToTheMatch(name);

            if (MyScoreSoccerPage.LiveTub.Displayed)
            {
                MyScoreSoccerPage.SwitchToLast();
            }

            var matchPage = new MatchPage(driver);

            matchPage.LiveCentreSection.LineUpsTab.Click();

            var x1 = matchPage.LiveCentreSection.MatchReviewSection.DifferenceInLossesOfLeadingPlayers();

            matchPage.TableTab.Click();
            var tablePage = new TableSection(driver);
            var x2 = tablePage.X2();

            var x3 = tablePage.X3();

            var x4 = tablePage.X4();

            var x5 = tablePage.X5();

            LeagueScenarios scenarious = new LeagueScenarios();
            var result = scenarious.PremierLeague(x1, x2, x3, x4, x5);
        }

        [TestMethod]
        public void GetCoefForTheNextMatch()
        {
            var name = "Бёрнли";
            MyScoreSoccerPage.Navigate();
            MyScoreSoccerPage.NextDayArrow.Click();
            MyScoreSoccerPage.NavigateToTheMatch(name);

            if (MyScoreSoccerPage.LiveTub.Displayed)
            {
                MyScoreSoccerPage.SwitchToLast();
            }

            var matchPage = new MatchPage(driver);

            var x1 = matchPage.LiveCentreSection.MatchReviewSection.DifferenceInLossesOfLeadingPlayers();

            matchPage.TableTab.Click();
            var tablePage = new TableSection(driver);
            var x2 = tablePage.X2();

            var x3 = tablePage.X3();

            var x4 = tablePage.X4();

            var x5 = tablePage.X5();

            LeagueScenarios scenarious = new LeagueScenarios();
            var result = scenarious.PremierLeague(x1, x2, x3, x4, x5);
        }
    }
}
