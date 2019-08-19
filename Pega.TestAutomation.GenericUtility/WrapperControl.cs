using System.Xml.Serialization;
using System.Xml.Serialization;

namespace Pega.TestAutomation.GenericUtility
{
    public class UIControl
    {
        #region Fields

        private string m_name;

        #endregion

        #region Constructors

        public UIControl(UIControl parent)
        {
            this.Parent = parent;
        }

        public UIControl()
        {

        }

        #endregion

        #region Properties

        public object NativeControl { get; set; }

        internal UIControl Parent { get; set; }

        /// <summary>
        /// Name to be used to save the control in repository file
        /// This will be used as display purpose and not for identification
        /// </summary>
        [XmlAttribute(AttributeName ="DisplayName")]
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        [XmlAttribute(AttributeName ="Technology")]
        public virtual TechnologyTypes TechnologyType { get; set; }

        [XmlAttribute(AttributeName = "ApplicationType")]
        public virtual ApplicationTypes ApplicationType { get; set; }

        SearchCriteria m_SearchCriteria;

        [XmlElement(ElementName = "SearchCriteria")]
        public SearchCriteria SearchCriteria
        {
            get
            {
                if (m_SearchCriteria == null)
                    m_SearchCriteria = new SearchCriteria();
                return m_SearchCriteria;
            }
            set
            {
                m_SearchCriteria = value;
            }
        }

        [XmlElement(ElementName = "PlaybackCriteria")]
        public PlaybackCriteria PlaybackCriteria { get; set; }

        [XmlIgnore]
        public PropertiesCollection SearchProperties
        {
            get { return SearchCriteria.SearchProperties; }
            set { SearchCriteria.SearchProperties = value; }
        }
        [XmlIgnore]
        public PropertiesCollection FilterProperties
        {
            get { return SearchCriteria.FilterProperties; }
            set { SearchCriteria.FilterProperties = value; }
        }

        #endregion
    }
}
