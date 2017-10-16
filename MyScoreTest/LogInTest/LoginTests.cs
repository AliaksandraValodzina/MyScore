using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using LogInTest.Pages.SignUpPage;
using System.Linq;
using LogInTest.Enum;
using LogInTest.Pages.MatchPages;
using LogInTest.Utils.Driver;
using LogInTest.Pages.MatchPages.Sections.TableSection;
using LogInTest.Pages;

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
            MyScoreSoccerPage.NavigateToTheMatch("Гомель");
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
            MyScoreSoccerPage.Navigate();
            MyScoreSoccerPage.LiveTub.Click();
            MyScoreSoccerPage.SwitchToLastAndClose();
            MyScoreSoccerPage.SelectAllMatchesOnThePage();
        }

        [TestMethod]
        public void GetCoef()
        {
            var name = "Гомель";
            MyScoreSoccerPage.Navigate();
            var matchPage = MyScoreSoccerPage.NavigateToTheMatch(name);
            matchPage.SwitchToLast();

            /*
            var x1 = matchPage.LiveCentreSection.MatchReviewSection.DifferenceInLossesOfLeadingPlayers();
            */

            //var tableTub = matchPage.ClickToTableTab();

            matchPage.TableTab.Click();
            var tablePage = new TableSection(driver);
            tablePage.X2(name);
        }
    }
}
