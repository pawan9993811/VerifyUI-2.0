using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Pega.TestAutomation.GenericUtility.Repository
{
    public class RepositoryUtility
    {
        public void WriteData(RepositoryNode parentNode, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(RepositoryNode));
            TextWriter tw = new StreamWriter(filePath);
            //XmlWriter writer = XmlWriter.Create(filePath);
            serializer.Serialize(tw, parentNode);
            tw.Close();
        }

        public RepositoryNode ReadData(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(RepositoryNode));
            FileStream fs = new FileStream(filePath, FileMode.Open);
            RepositoryNode node = (RepositoryNode)serializer.Deserialize(fs);
            return node;
        }


    }
}
