using System;

namespace Pega.TestAutomation.GenericUtility
{
    /// <summary>
    /// 
    /// </summary>
    public class GenericScript
    {
        #region Initilization Parts

        private ObjDict keyActionValuePair;

        public ObjDict KeyActionValuePair
        {
            get
            {
                if(keyActionValuePair == null)
                     keyActionValuePair =  new ObjDict();
                return keyActionValuePair;
            }
        }


        #endregion

        #region Action methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="action"></param>
        /// <param name="value"></param>
        /// <param name="waitTime"></param>
        protected ReturnObject PerformAction(UIControl control, string action, string inputValue, int waitTime)
        {
            ReturnObject rc = new ReturnObject();

            //get the control from string

            //create action helper
            ActionInfo actionInfo = new ActionInfo(action, inputValue, waitTime);
            ActionHelper actionHelper = ActionHelperFactory.Create(control, actionInfo);
            actionHelper.PerformAction();

            //do required default sync

            //report and log

            return rc;

        }

        public ReturnObject PerformAction(ObjDict objDict)
        {
            ReturnObject rc = new ReturnObject();
            foreach (var item in objDict.ControlKeys)
            {
                objDict.MoveNext();

                if (objDict.CurrentControlKey is string)
                    PerformAction(objDict.CurrentControlKey.ToString(), objDict.CurrentAction, objDict.CurrentValue.ToString(), (int)objDict.CurrentWaitTime);
                else if (objDict.CurrentControlKey is UIControl)
                    PerformAction((UIControl)objDict.CurrentControlKey, objDict.CurrentAction, objDict.CurrentValue.ToString(), (int)objDict.CurrentWaitTime);
            }

            return rc;
        }

        protected ReturnObject PerformAction(string control, string action, string inputValue, int waitTime)
        {
            ReturnObject rc = new ReturnObject();
            UIControl control1 = new UIControl();
            PerformAction(control1, action, inputValue, waitTime);
            return rc;
        }

        protected ReturnObject PerformValidation(UIControl control, string validation, string expectedValue, int waitTime)
        {
            ReturnObject rc = new ReturnObject();

            //get the control from string

            //create action helper
            ActionInfo actionInfo = new ActionInfo(validation, expectedValue, waitTime);
            ActionHelper actionHelper = ActionHelperFactory.Create(control, actionInfo);
            actionHelper.PerformAction();

            //do required default sync

            //report and log

            return rc;

        }

        protected ReturnObject PerformSync(UIControl control, string validation, string expectedValue, int waitTime)
        {
            ReturnObject rc = new ReturnObject();

            //get the control from string

            //create action helper
            ActionInfo actionInfo = new ActionInfo(validation, expectedValue, waitTime);
            ActionHelper actionHelper = ActionHelperFactory.Create(control, actionInfo);
            actionHelper.PerformAction();

            //do required default sync

            //report and log

            return rc;

        }



        #endregion

        #region Reporting/Logging methods
        protected void ReportError(ReturnObject rc, string message = "")
        {
            if (rc.Status == EnumErrorType.Failure || rc.Status == EnumErrorType.Inconclusive)
                throw new BreakExecutionException(rc);
        }

        protected void ReportError(EnumErrorType overridingStatus, ReturnObject rc, string msg)
        {
            if (rc.Status == EnumErrorType.Failure || rc.Status == EnumErrorType.Inconclusive)
                throw new BreakExecutionException(rc);
        }
        #endregion
    }
}
