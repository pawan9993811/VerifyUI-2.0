using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Pega.TestAutomation.GenericUtility
{
    /// <summary>
    /// 
    /// </summary>
    public class PropertiesCollection : ICollection<Property>
    {
        #region Properties
        private List<Property> _properties;

        public int Count
        {
            get { return _properties.Count; }
        }

        public bool IsReadOnly { get { return false; } }

        #endregion

        #region Constructors
        public PropertiesCollection()
        {
            _properties = new List<Property>();
        }
        #endregion
        #region Methods
        /// <summary>
        /// Add property to the collection with name and value
        /// Specify the matching criteria to be used if this value compared against any other value.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        public void Add(string name,string value,StringComparer comparer)
        {
            _properties.Add(new Property() { Name = name, Value = value, Comparer = comparer });
        }

        /// <summary>
        /// Add property to the collection with name and value
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void Add(string name,string value)
        {
            _properties.Add(new Property() { Name = name, Value = value});
        }

        public void Add(Property item)
        {
            _properties.Add(item);
        }

        public void Clear()
        {
            _properties.Clear();
        }

        public bool Contains(Property item)
        {
            Property reqelement = _properties.Find(element => element.Name.Equals(item.Name, StringComparison.OrdinalIgnoreCase));
            return reqelement != null; 
        }

        public void CopyTo(Property[] array, int arrayIndex)
        {
            
        }

        public IEnumerator<Property> GetEnumerator()
        {
            //willl imlement
            return _properties.GetEnumerator();
        }

        /// <summary>
        /// Remove property from the collection using name. 
        /// </summary>
        /// <param name="name"></param>
        public bool Remove(string name)
        {
            Property reqelement = _properties.Find(element => element.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (reqelement == null) return false;
            _properties.Remove(reqelement);
            return true;
        }

        public bool Remove(Property item)
        {
            Property reqelement = _properties.Find(element => element.Name.Equals(item.Name, StringComparison.OrdinalIgnoreCase));
            if (reqelement == null) return false;
            _properties.Remove(reqelement);
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }

        #endregion
    }

    public class Property
    {
        #region Properties
        /// <summary>
        /// Name of the property
        /// </summary>
        [XmlAttribute(AttributeName ="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Property value
        /// </summary>
        [XmlAttribute(AttributeName ="Value")]
        public string Value { get; set; }

        /// <summary>
        /// String comparer can be used if you need to compare this value against other
        /// </summary>
        public StringComparer Comparer { get; set; }

        #endregion
    }

    public class SearchCriteria
    {

        PropertiesCollection m_SearchProperties;
        /// <summary>
        /// Search properties collection to be used for identify the control
        /// </summary>
        [XmlArray(ElementName = "SearchProperties")]
        [XmlArrayItem(ElementName ="Property")]
        public PropertiesCollection SearchProperties
        {
            get
            {
                if (m_SearchProperties == null)
                    m_SearchProperties = new PropertiesCollection();
                return m_SearchProperties;
            }
            set
            {
                m_SearchProperties = value;
            }
        }

        PropertiesCollection m_FilterProperties;

        /// <summary>
        /// Filter properties collection to be used for identify the control
        /// </summary>
        [XmlArray(ElementName = "FilterProperties")]
        [XmlArrayItem(ElementName ="Property")]
        public PropertiesCollection FilterProperties
        {
            get
            {
                if (m_FilterProperties == null)
                    m_FilterProperties = new PropertiesCollection();
                return m_FilterProperties;
            }
            set
            {
                m_FilterProperties = value;
            }
        }

        [XmlElement(ElementName = "SearchConfiguration", IsNullable = false)]
        public SearchConfiguration SearchConfiguration { get; set; }
    }

    public class SearchConfiguration
    {

    }

    public class PlaybackCriteria
    {

    }
}
