using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClipboardTurbo {
    interface IXmlManager {

        string XmlPath { get; set; }

        void WriteInformation<TXmlType>(List<TXmlType> list);
        List<TXmlType> ReadInformation<TXmlType>();

        void PrepareXmlFolder(string directory);

    }
}
