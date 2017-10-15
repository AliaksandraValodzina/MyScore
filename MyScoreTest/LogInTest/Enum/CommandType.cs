using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInTest.Enum
{
    public enum CommandType
    {
        /// <summary>
        /// Home
        /// </summary>
        [StringValue("Home")]
        Home,

        /// <summary>
        /// Away
        /// </summary>
        [StringValue("Away")]
        Away
    }
}
