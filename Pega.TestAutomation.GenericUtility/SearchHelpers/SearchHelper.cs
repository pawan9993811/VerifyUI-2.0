using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pega.TestAutomation.GenericUtility
{
    internal abstract class SearchHelper
    {
        #region Properties
        internal UIControl ControlToSearch { get; set; }
        #endregion
        public SearchHelper(UIControl control)
        {
            ControlToSearch = control;
        }

        #region Methods
        internal abstract object GetControl();

        #endregion

    }
}
