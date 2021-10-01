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

        private string appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string configfilePath;
        private string configfileName = "ClipboardTurbo_Settings.xml";

        private static XmlSerializer serializer = new XmlSerializer(typeof(List<Config>));
        private static XmlSerializer deserializer = new XmlSerializer(typeof(List<Config>));

        public SettingsController()
        {
            configfilePath = Path.Combine(appdataPath, "ClipboardTurbo");

            PrepareConfigFolder(configfilePath);
        }

        // Prüft, ob Ordner für Konfigurationsdatei existiert, falls nicht wird er im Appdata Verzeichnis angelegt.
        private void PrepareConfigFolder(string configfilePath)
        {
            if (!Directory.Exists(configfilePath)) {
                Directory.CreateDirectory(configfilePath);
            }
        }
        
        public void WriteInformation(List<Information> information) {
            using (TextWriter writer = new StreamWriter(Path.Combine(configfilePath, configfileName))) {
                serializer.Serialize(writer, information);
            }
        }

        public List<Information> ReadInformation() {
            using(StreamReader stream = new StreamReader(Path.Combine(configfilePath, configfileName))) {
                return (List<Information>)deserializer.Deserialize(stream);
            }
        }

    }
}
