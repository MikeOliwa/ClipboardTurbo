using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ClipboardTurbo.Controller {
    public class SettingsController {

        List<Information> InformationList = new List<Information> { };

        private string dataFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ClipboardTurbo");
        private string dataFileName = "ClipboardTurbo_Config.xml";

        private static XmlManager serializer_forConfiguration;



        public SettingsController()
        {
            serializer_forConfiguration = new XmlManager(Path.Combine(dataFilePath, dataFileName));


        }


        

    }
}
