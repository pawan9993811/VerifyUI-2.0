using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pega.TestAutomation.GenericUtility
{
    /// <summary>
    /// Used for Breaking the execution of test script or Function
    /// </summary>
    public class BreakExecutionException : Exception
    {

        #region Constructors

        public BreakExecutionException()
            : base()
        {

        }

        public BreakExecutionException(ReturnObject rc)
            : base()
        {
            this.rc = rc;
        }

        #endregion

        #region Members

        private ReturnObject m_rc;

        public ReturnObject rc
        {
            get { return m_rc; }
            set { m_rc = value; }
        }

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion

    }
}
