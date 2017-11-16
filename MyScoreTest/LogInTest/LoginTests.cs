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

        private string GetFyzzyCoef()
        {
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

            return result;
        }

        private string GetCoef(string fyzzyCoef)
        {
            var matchPage = new MatchPage(driver);
            matchPage.CoefTab.Click();
            return matchPage.CoefSection.GetCoef(fyzzyCoef);
        }

        private void NavigateToTheMatch(string name)
        {
            MyScoreSoccerPage.NavigateToTheMatch(name);

            if (MyScoreSoccerPage.LiveTub.Displayed)
            {
                MyScoreSoccerPage.SwitchToLast();
            }
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
            var name = "Кадис";
            NavigateToTheMatch(name);
            var coef = GetFyzzyCoef();
        }

        [TestMethod]
        public void GetCoefForTheLeague()
        {
            var league = "Премьер-лига";
            MyScoreSoccerPage.Navigate();
            MyScoreSoccerPage.NextDayArrow.Click();
            MyScoreSoccerPage.NextDayArrow.Click();
            var commands = MyScoreSoccerPage.HomeCommandsForLeague(league);

            foreach(var command in commands)
            {
                NavigateToTheMatch(command.Text);
                var fyzzyCoef = GetFyzzyCoef();
                var coef = GetCoef(fyzzyCoef);
                MyScoreSoccerPage.SwitchToLastAndClose();
            }
        }


        [TestMethod]
        public void GetCoefForThePreviousMatch()
        {
            var name = "Хорн";
            MyScoreSoccerPage.Navigate();
            MyScoreSoccerPage.PreviousDayArrow.Click();
            var commands = MyScoreSoccerPage.HomeCommandsForLeague(name);
            // matchPage.LiveCentreSection.LineUpsTab.Click();

            var coef = GetFyzzyCoef();
        }

        [TestMethod]
        public void GetCoefForTheNextMatch()
        {
            var name = "Хорн";
            MyScoreSoccerPage.Navigate();
            MyScoreSoccerPage.NextDayArrow.Click();
            MyScoreSoccerPage.NextDayArrow.Click();
            var commands = MyScoreSoccerPage.HomeCommandsForLeague(name);

            var coef = GetFyzzyCoef();
        }
    }
}
