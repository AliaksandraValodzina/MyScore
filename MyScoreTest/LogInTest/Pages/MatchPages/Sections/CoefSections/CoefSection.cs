using LogInTest.Pages.MatchPages.Sections.StatisticSections;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Linq;

namespace LogInTest.Pages.MatchPages.Sections.LiveCentreSections
{
    /// <summary>
    /// Coef Section.
    /// </summary>
    public partial class CoefSection : BasePage
    {
        /// <summary>
        /// LiveCentreSection constructor.
        /// </summary>
        public CoefSection(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Get 1 coef.
        /// </summary>
        public string Coef1()
        {
            return OneXTwoCoefs.First().Text;
        }

        /// <summary>
        /// Get X coef.
        /// </summary>
        public string CoefX()
        {
            return OneXTwoCoefs.ElementAt(1).Text;
        }

        /// <summary>
        /// Get 2 coef.
        /// </summary>
        public string Coef2()
        {
            return OneXTwoCoefs.ElementAt(2).Text;
        }

        /// <summary>
        /// Get handicap 0 coef for the first command.
        /// </summary>
        public string Handicap0ForFirstCommand()
        {
            return HandicapNull.ElementAt(0).Text;
        }

        /// <summary>
        /// Get handicap 0 coef for the second command.
        /// </summary>
        public string Handicap0ForSecondCommand()
        {
            return HandicapNull.ElementAt(1).Text;
        }

        /// <summary>
        /// Get handicap 1 coef for the first command.
        /// </summary>
        public string HandicapPlus1ForFirstCommand()
        {
            return HandicapPlusOne.ElementAt(0).Text;
        }

        /// <summary>
        /// Get handicap 1 coef for the second command.
        /// </summary>
        public string HandicapPlus1ForSecondCommand()
        {
            return HandicapPlusOne.ElementAt(1).Text;
        }

        /// <summary>
        /// Get handicap -1 coef for the first command.
        /// </summary>
        public string HandicapMinus1ForFirstCommand()
        {
            return HandicapMinusOne.ElementAt(0).Text;
        }

        /// <summary>
        /// Get handicap -1 coef for the second command.
        /// </summary>
        public string HandicapMinus1ForSecondCommand()
        {
            return HandicapMinusOne.ElementAt(1).Text;
        }

        /// <summary>
        /// Get coef.
        /// </summary>
        public string GetCoef(string fuzzyCoef)
        {
            var doubleFyzzyCoef = Convert.ToDouble(fuzzyCoef);
            var coef = "Coef was not matched";

            if (doubleFyzzyCoef.Equals(0.0))
            {
                coef = "coef_X = " + CoefX();
            } else if (doubleFyzzyCoef > 0.0 && doubleFyzzyCoef <= 1.0)
            {
                HandicapTub.Click();
                coef = "coef_F1(0) = " + Handicap0ForFirstCommand();
            } else if (doubleFyzzyCoef > 1.0 && doubleFyzzyCoef <= 2.0)
            {
                coef = "coef_1 = " + Coef1();
            } else if (doubleFyzzyCoef > 2.0)
            {
                HandicapTub.Click();
                coef = "coef_F1(-1) = " + HandicapMinus1ForFirstCommand();
            }
            else if (doubleFyzzyCoef < 0.0 && doubleFyzzyCoef >= -1.0)
            {
                HandicapTub.Click();
                coef = "coef_F2(0) = " + Handicap0ForSecondCommand();
            }
            else if (doubleFyzzyCoef < -1.0 && doubleFyzzyCoef >= -2.0)
            {
                coef = "coef_2 = " + Coef2();
            }
            else if (doubleFyzzyCoef < -2.0)
            {
                HandicapTub.Click();
                coef = "coef_F2(-1) = " + HandicapMinus1ForSecondCommand();
            }

            return coef;
        }
    }
}
