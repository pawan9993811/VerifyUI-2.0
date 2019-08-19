using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pega.TestAutomation.GenericUtility
{
    internal class DesktopSearchHelper : SearchHelper
    {
        public DesktopSearchHelper(UIControl control):base(control)
        {

        }

        internal override object GetControl()
        {
            throw new NotImplementedException();
        }
    }
}
