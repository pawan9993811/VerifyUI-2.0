using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pega.TestAutomation.GenericUtility
{
    public enum EnumErrorType
    {
        /// <summary>
        /// Undefined error
        /// </summary>
        None = 0,      //default - but having this option at the end is indicative of some coding problem.
        /// <summary>
        /// SUCCESS type
        /// </summary>
        Success = 1,
        /// <summary>
        /// INFO type
        /// </summary>
        Info = 2,
        /// <summary>
        /// WARNING type
        /// </summary>
        Warning = 4,
        /// <summary>
        /// Failure type
        /// </summary>
        Failure = 8,
        /// <summary>
        /// Inconclusive type (Used when script fails before starting of actual work flow)
        /// </summary>
        Inconclusive = 16,
        /// <summary>
        /// Test Timeout is exceeded
        /// </summary>
        TimedOut = 32

    }
}
