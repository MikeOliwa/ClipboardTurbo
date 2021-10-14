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

        private string dataFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ClipboardTurbo");
        private string dataFileName = "ClipboardTurbo_Data.xml";

        private static XmlManager xmlManager;

        public ClipboardController() {

            xmlManager = new XmlManager(Path.Combine(dataFilePath, dataFileName));

            xmlManager.PrepareXmlFolder(dataFilePath);

            if (File.Exists(Path.Combine(dataFilePath, dataFileName))){
                InformationList = xmlManager.ReadInformation<Information>();
                xmlManager.WriteInformation(InformationList);
            } else {
                xmlManager.WriteInformation(InformationList);
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
            if(InformationList.Count == 0) {
                return 0;
            } else {
            return InformationList.Last().Id + 1;
            }
        }

        public void SetIds() {
            int id = 0;
            foreach(Information information in InformationList) {
                information.Id = id;
                id++;
            }
            xmlManager.WriteInformation(InformationList);
        }

        public bool AddInformation(int id, string name, string value) {
            InformationList = xmlManager.ReadInformation<Information>();
            Information information = new Information {Id = id, Name = name, Value = value };

            if (!CheckInformationExists(information)) {
                InformationList.Add(information);
                xmlManager.WriteInformation(InformationList);
                return true;
            } else {
                MessageBox.Show($"Information ({name}) already exists.","Duplicate information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
        }

        public bool EditInformation(int id,string name, string value) {
            InformationList = xmlManager.ReadInformation<Information>();
            foreach (Information information in InformationList){
                if (information.Id == id) {
                    information.Name = name;
                    information.Value = value;
                    xmlManager.WriteInformation(InformationList);
                    return true;
                }
            }
            return false;
        }

        public bool DeleteInformation(int id) {
            InformationList = xmlManager.ReadInformation<Information>();
            foreach (Information information in InformationList) {
                if (information.Id == id) {
                    InformationList.RemoveAt(id);
                    SetIds();
                    xmlManager.WriteInformation(InformationList);
                    return true;
                }
            }
            return false;
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

