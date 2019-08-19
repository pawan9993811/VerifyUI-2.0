using System.Collections.Generic;
using System.Xml.Serialization;

namespace Pega.TestAutomation.GenericUtility.Repository
{
    [XmlRoot]
    public class RepositoryNode
    {
        [XmlElement(ElementName ="ControlNode")]
        public List<UIControl> ChildNodes { get; set; }

        public RepositoryNode()
        {
            ChildNodes = new List<UIControl>();
        }
    }
}
