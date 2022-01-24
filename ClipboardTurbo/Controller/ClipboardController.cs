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

        //Fields
        List<Information> InformationList = new List<Information> { };

        //Constructor
        private ClipboardController(string currentPath)
            : base(currentPath, "ClipboardTurbo_Data.xml") {
        }

        //Factory Method
        public static ClipboardController Create() {

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ClipboardTurbo\filepath.txt")) {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ClipboardTurbo");
                using (StreamWriter sw = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ClipboardTurbo\filepath.txt")) {
                    sw.Write(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ClipboardTurbo");
                }
            }

            string currentPath = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ClipboardTurbo\filepath.txt");
            var controller = new ClipboardController(currentPath);

            if (File.Exists(Path.Combine(controller._dataFilePath, controller._dataFileName))) {
                controller.InformationList = controller._xmlManager.ReadInformation<Information>();
                controller._xmlManager.WriteInformation(controller.InformationList);
            }
            else {
                //Add sample data on first startup
                controller.InformationList.Add(new Information { Id = 0, Name = "My email address", Value = "sample@email.com" });
                controller.InformationList.Add(new Information { Id = 1, Name = "My identity card number", Value = "XX6RD4XFK" });
                controller.InformationList.Add(new Information { Id = 2, Name = "password I always forget", Value = "veryL0ngpw321!!Utek44" });
                controller._xmlManager.WriteInformation(controller.InformationList);
            }

            return controller;
        }

        //Methods / Functions
        public void RefreshListView(ComponentFactory.Krypton.Toolkit.KryptonListBox listView) {
            listView.Items.Clear();
            if (InformationList != null) {
                foreach (Information information in InformationList) {
                    listView.Items.Add(information.Name);
                }
            }
        }

        public int GetNextId() {
            if (InformationList.Count == 0) {
                return 0;
            }
            else {
                return InformationList.Last().Id + 1;
            }
        }

        public void SetIds() {
            int id = 0;
            foreach (Information information in InformationList) {
                information.Id = id;
                id++;
            }
            _xmlManager.WriteInformation(InformationList);
        }

        public bool AddInformation(int id, string name, string value) {
            InformationList = _xmlManager.ReadInformation<Information>();
            Information information = new Information { Id = id, Name = name, Value = value };

            if (!InformationExists(information)) {
                InformationList.Add(information);
                _xmlManager.WriteInformation(InformationList);
                return true;
            }
            else {
                MessageBox.Show($"Information ({name}) already exists.", "Duplicate information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public bool EditInformation(int id, string name, string value) {
            InformationList = _xmlManager.ReadInformation<Information>();
            Information editedInformation = new Information { Id = id, Name = name, Value = value };

            if (!InformationExists(editedInformation)) {
                Information information = InformationList.SingleOrDefault(x => x.Id == id);

                information.Name = name;
                information.Value = value;
                _xmlManager.WriteInformation(InformationList);
                return true;

            }
            else {
                MessageBox.Show($"Information ({name}) already exists.", "Duplicate information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


        }

        public bool DeleteInformation(int id) {
            InformationList = _xmlManager.ReadInformation<Information>();

            Information informationToDelete = InformationList.SingleOrDefault(x => x.Id == id);
            if (informationToDelete == null) return false;
            InformationList.RemoveAt(informationToDelete.Id);
            SetIds();
            _xmlManager.WriteInformation(InformationList);
            return true;

        }

        public void CleanInformation() {
            InformationList.Clear();
            _xmlManager.WriteInformation(InformationList);
        }

        private bool InformationExists(Information informationToInsert) {

            Information existingInformation = InformationList.SingleOrDefault(x => x.Id != informationToInsert.Id && x.Name == informationToInsert.Name);
            if(existingInformation != null) {
                return true;
            } else {
                //return false if existingInformation is null
                return false;
            }
        }

        public string GetInformationName(int id) {
            string result = String.Empty;

            Information information = InformationList.SingleOrDefault(x => x.Id == id);
            result = information.Name;
            CopyToClipboard(result);
            return result;
        }

        public string GetInformationValue(int id) {
            string result = String.Empty;
            Information information = InformationList.SingleOrDefault(x => x.Id == id);
            result = information.Value;
            CopyToClipboard(result);
            return result;
        }

        public void CopyToClipboard(string text) {
            if (text != null || text.Equals(String.Empty)) {
                System.Windows.Forms.Clipboard.SetText(text);
            }
        }

    }
}

