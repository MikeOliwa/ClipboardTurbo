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

        public int GetNextId() {
            //InformationList = ReadInformation();
            //int highestId = 0;

            //foreach(Information information in InformationList) {
            //    if(highestId < information.Id) {
            //        highestId = information.Id;
            //    }
            //}

            //return highestId + 1;

            if(InformationList.Count == 0) {
                return 0;
            } else {
            return InformationList.Last().Id + 1;
            }
        }

        public void SetIds() {
            int id = 0;
            ReadInformation();
            foreach(Information information in InformationList) {
                information.Id = id;
                id++;
            }
            WriteInformation(InformationList);
        }

        public bool AddInformation(int id, string name, string value) {
            InformationList = ReadInformation();
            Information information = new Information {Id = id, Name = name, Value = value };
            if (!CheckInformationExists(information)) {
                InformationList.Add(information);
                WriteInformation(InformationList);
                return true;
            } else {
                MessageBox.Show($"Information ({name}) already exists.","Duplicate information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
        }

        public bool EditInformation(int id,string name, string value) {
            InformationList = ReadInformation();
            foreach(Information information in InformationList){
                if (information.Id == id) {
                    information.Name = name;
                    information.Value = value;
                    WriteInformation(InformationList);
                    return true;
                }
            }
            return false;
        }

        public bool DeleteInformation(int id) {
            InformationList = ReadInformation();
            foreach (Information information in InformationList) {
                if (information.Id == id) {
                    InformationList.RemoveAt(id);
                    SetIds();
                    WriteInformation(InformationList);
                    return true;
                }
            }
            return false;
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

        public string GetValueOfInformation(int id) {
            string result = String.Empty;
            foreach(Information information in InformationList) {
                if(information.Id == id) {
                    result = information.Value;
                    CopyToClipboard(result);
                }
            }
            return result;
        }

        public void CopyToClipboard(string text) {
            if(text != null || text.Equals(String.Empty)) {
                System.Windows.Forms.Clipboard.SetText(text);
            }
        }

    }
} 

