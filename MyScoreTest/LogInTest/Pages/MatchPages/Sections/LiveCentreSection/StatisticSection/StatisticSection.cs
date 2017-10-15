using LogInTest.Enum;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace LogInTest.Pages.MatchPage.Sections.StatisticSection
{
    /// <summary>
    /// StatisticSection class.
    /// </summary>
    public partial class StatisticSection : BasePage
    {
        /// <summary>
        /// Get Shots On Goal by command 
        /// </summary>
        /// <param name="commandType">The command type</param>
        /// <returns>The shots on goal</returns>
        public string GetShotsOnGoalText(CommandType commandType)
        {
            if (commandType.Equals(CommandType.Home))
            {
                return ShotsOnGoalHome.Text;
            }
            else
            {
                return ShotsOnGoalAway.Text;
            }
        }

        /// <summary>
        /// Update Shots List method. 
        /// </summary>
        /// <param name="type">The command type.</param>
        /// <param name="command">The command.</param>
        /// <param name="shortsList">The shorts list</param>
        /// <returns>Updated shorts list.</returns>
        public IList<string> UpdateShotsList(CommandType type, string command, IList<string> shortsList)
        {
            var shot = GetShotsOnGoalText(type);
            shortsList.Add(shot);

            return shortsList;
        }
    }
}
