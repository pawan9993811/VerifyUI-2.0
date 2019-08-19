namespace Pega.TestAutomation.GenericUtility
{
    internal class SearchHelperFactory
    {
        public static SearchHelper Create(UIControl control)
        {
            switch (control.ApplicationType)
            {
                case ApplicationTypes.Windows:
                    return new DesktopSearchHelper(control);
                case ApplicationTypes.Web:
                    return new WebSearchHelper(control);
                default:
                    return null;
            }
        }
    }
}
