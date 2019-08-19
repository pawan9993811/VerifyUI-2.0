namespace Pega.TestAutomation.GenericUtility
{
    class ActionHelperFactory
    {
        public static ActionHelper Create(UIControl control, ActionInfo actionValues)
        {
            switch (control.TechnologyType)
            {
                case TechnologyTypes.White:
                    return new WhiteActionHelper(control, actionValues);
                case TechnologyTypes.Selenium:
                    return new SeleniumActionHelper(control, actionValues);
                default:
                    return null;
            }
        }

    }
}
