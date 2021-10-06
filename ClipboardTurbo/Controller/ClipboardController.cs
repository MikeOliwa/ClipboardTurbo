using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using ClipboardTurbo.View;
using ClipboardTurbo.Controller;

namespace ClipboardTurbo.Controller {
    public class ClipboardController {

        List<Information> InformationList = new List<Information> { };

        private string appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string datafilePath;
        private string datafileName = "ClipboardTurbo_Data.xml";

        private static XmlSerializer serializer = new XmlSerializer(typeof(List<Information>));
        private static XmlSerializer deserializer = new XmlSerializer(typeof(List<Information>));

        public ClipboardController() {

            datafilePath = Path.Combine(appdataPath, "ClipboardTurbo");

            PrepareConfigFolder(datafilePath);

            if (File.Exists(Path.Combine(datafilePath, datafileName))){
                InformationList = ReadInformation();
                WriteInformation(InformationList);
            } else {
                WriteInformation(InformationList);
            }

        }

        // Prüft, ob Ordner für Konfigurationsdatei existiert, falls nicht wird er im Appdata Verzeichnis angelegt.
        private void PrepareConfigFolder(string configfilePath) {
            if (!Directory.Exists(configfilePath)) {
                Directory.CreateDirectory(configfilePath);
            }
        }

        public void RefreshListView(ListView listView) {
            listView.Items.Clear();
            if(InformationList != null) {
                foreach (Information information in InformationList) {
                listView.Items.Add(information.Name);
                }
            }
        }

        public bool AddInformation(string name, string value) {
            InformationList = ReadInformation();
            Information information = new Information { Name = name, Value = value };
            if (!CheckInformationExists(information)) {
                InformationList.Add(information);
                WriteInformation(InformationList);
                return true;
            } else {
                MessageBox.Show($"Information ({name}) already exists.","Duplicate information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
        }

        public void WriteInformation(List<Information> information) {
            using (TextWriter writer = new StreamWriter(Path.Combine(datafilePath, datafileName))) {
                serializer.Serialize(writer, information);
            }
        }

        public List<Information> ReadInformation() {
            using (StreamReader stream = new StreamReader(Path.Combine(datafilePath, datafileName))) {
                return (List<Information>)deserializer.Deserialize(stream);
            }
        }

        private bool CheckInformationExists(Information informationToInsert) {
            foreach (Information information in InformationList) {
                if(information.Name == informationToInsert.Name) {
                    return true;
                } 
            }
            return false;
        }

        public string GetValueOfInformation(string name) {
            string result = String.Empty;
            foreach(Information information in InformationList) {
                if(information.Name == name) {
                    result = information.Value;
                }
            }
            return result;
        }

        public void CopyToClipboard(string text) {
            System.Windows.Forms.Clipboard.SetText(text);
        }

    }
} 

