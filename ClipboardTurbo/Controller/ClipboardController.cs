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
    public class ClipboardController : BaseController {

        List<Information> InformationList = new List<Information> { };

        private ClipboardController(string currentPath)
            : base(currentPath, "ClipboardTurbo_Data.xml") {
        }

        public static ClipboardController Create() {

            if (!File.Exists(@"C:\Users\mikea\AppData\Roaming\ClipboardTurbo\ClipboardTurbo_Path.txt")) {
                using (StreamWriter sw = File.CreateText(@"C:\Users\mikea\AppData\Roaming\ClipboardTurbo\ClipboardTurbo_Path.txt")) {
                    sw.Write(@"C:\Users\mikea\AppData\Roaming\ClipboardTurbo");
                }
            }

            string currentPath = System.IO.File.ReadAllText(@"C:\Users\mikea\AppData\Roaming\ClipboardTurbo\ClipboardTurbo_Path.txt");
            var controller = new ClipboardController(currentPath);

            if (File.Exists(Path.Combine(controller._dataFilePath, controller._dataFileName))) {
                controller.InformationList = controller._xmlManager.ReadInformation<Information>();
                controller._xmlManager.WriteInformation(controller.InformationList);
            }
            else {
                controller._xmlManager.WriteInformation(controller.InformationList);
            }

            return controller;
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
            _xmlManager.WriteInformation(InformationList);
        }

        public bool AddInformation(int id, string name, string value) {
            InformationList = _xmlManager.ReadInformation<Information>();
            Information information = new Information {Id = id, Name = name, Value = value };

            if (!CheckInformationExists(information)) {
                InformationList.Add(information);
                _xmlManager.WriteInformation(InformationList);
                return true;
            } else {
                MessageBox.Show($"Information ({name}) already exists.","Duplicate information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
        }

        public bool EditInformation(int id,string name, string value) {
            InformationList = _xmlManager.ReadInformation<Information>();
            foreach (Information information in InformationList){
                if (information.Id == id) {
                    information.Name = name;
                    information.Value = value;
                    _xmlManager.WriteInformation(InformationList);
                    return true;
                }
            }
            return false;
        }

        public bool DeleteInformation(int id) {
            InformationList = _xmlManager.ReadInformation<Information>();
            foreach (Information information in InformationList) {
                if (information.Id == id) {
                    InformationList.RemoveAt(id);
                    SetIds();
                    _xmlManager.WriteInformation(InformationList);
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

