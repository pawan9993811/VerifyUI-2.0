namespace Pega.TestAutomation.GenericUtility
{
    public class ReturnObject
    {
        #region fileds

        EnumErrorType status;
        object returnValue;
        string errorDescription;

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public EnumErrorType Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// Gets or sets the return value.
        /// </summary>
        /// <value>The return value.</value>
        public object ReturnValue
        {
            get { return returnValue; }
            set { returnValue = value; }
        }

        /// <summary>
        /// Error description
        /// </summary>
        public string ErrorDescription
        {
            get { return errorDescription; }
            set { errorDescription = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        public ReturnObject(EnumErrorType status)
        {
            this.Status = status;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReturnObject()
        {
            Status = EnumErrorType.Success;
        }
        #endregion
    }
}
