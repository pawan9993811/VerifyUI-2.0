using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pega.TestAutomation.GenericUtility
{
    class WebSearchHelper:SearchHelper
    {
        public WebSearchHelper(UIControl control):base(control)
        {

        }

        internal override object GetControl()
        {
            if (ControlToSearch.NativeControl != null) return ControlToSearch.NativeControl;

            //strat searching logic
            return null;

        }
    }
}
