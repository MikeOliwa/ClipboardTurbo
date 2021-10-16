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

        List<Configuration> SettingsList = new List<Configuration> { };

        private string dataFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ClipboardTurbo");
        private string dataFileName = "ClipboardTurbo_Config.xml";

        private static XmlManager xmlManager;



        public SettingsController()
        {
            xmlManager = new XmlManager(Path.Combine(dataFilePath, dataFileName));

            xmlManager.PrepareXmlFolder(dataFilePath);

            if (File.Exists(Path.Combine(dataFilePath, dataFileName))) {
                SettingsList = xmlManager.ReadInformation<Configuration>();
                xmlManager.WriteInformation(SettingsList);
            }
            else {
                xmlManager.WriteInformation(SettingsList);
            }
            
        }       

    }

}
