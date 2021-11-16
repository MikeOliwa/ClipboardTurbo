using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ClipboardTurbo {
    public class XmlManager : IXmlManager {

        //Properies
        public string XmlPath { get; set; }

        //Constructor
        public XmlManager(string path) => this.XmlPath = path;

        //Methods / Functions
        public void PrepareXmlFolder(string directory) {
            if (!Directory.Exists(directory)) {
                Directory.CreateDirectory(directory);
            }
        }

        public void WriteInformation<TXmlType>(List<TXmlType> list) {

            XmlSerializer serializer = new XmlSerializer(typeof(List<TXmlType>));

            using (TextWriter writer = new StreamWriter(XmlPath)) {
                serializer.Serialize(writer, list);
            }
        }

        public List<TXmlType> ReadInformation<TXmlType>(){

            XmlSerializer deserializer = new XmlSerializer(typeof(List<TXmlType>));

                using (StreamReader stream = new StreamReader(XmlPath)) {
                    return (List<TXmlType>)deserializer.Deserialize(stream);
                }
        }
    }
}