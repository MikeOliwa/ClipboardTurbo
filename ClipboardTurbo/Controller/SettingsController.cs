using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ClipboardTurbo.Controller {
    public class SettingsController : BaseController {

        //Fields
        public List<Configuration> SettingsList = new List<Configuration> { };

        //Constructor
        private SettingsController(string currentPath)
            : base(currentPath, "ClipboardTurbo_Config.xml") {
        }

        //Factory Method
        public static SettingsController Create() {
            string currentPath = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ClipboardTurbo\filepath.txt");
            var controller = new SettingsController(currentPath);

            if (File.Exists(Path.Combine(controller._dataFilePath, controller._dataFileName))) {
                controller.SettingsList = controller._xmlManager.ReadInformation<Configuration>();
                controller._xmlManager.WriteInformation(controller.SettingsList);
            }
            else {
                controller.SettingsList.Add(new Configuration { Setting = Setting.KeyboardShortcut, Value = "" });
                controller.SettingsList.Add(new Configuration { Setting = Setting.KeepWindowOnTop, Value = "0" });
                controller.SettingsList.Add(new Configuration { Setting = Setting.StartWithWindows, Value = "0" });
                controller._xmlManager.WriteInformation(controller.SettingsList);
            }

            controller.SettingsList = controller._xmlManager.ReadInformation<Configuration>();

            return controller;
        }

        //Methods / Functions
        public void SetFilesDirectory(string newPath) {

            string currentPath = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ClipboardTurbo\filepath.txt");

            List<string> files = Directory.GetFiles(currentPath).ToList();
            foreach (string file in files) {
                if (file.Contains("ClipboardTurbo_")) {
                    if (!File.Exists(file)) {
                        File.Copy(currentPath + '\\' + file.Substring(file.LastIndexOf('\\')), newPath + '\\' + file.Substring(file.LastIndexOf('\\')));
                        File.Delete(currentPath + '\\' + file.Substring(file.LastIndexOf('\\')));
                    }
                }
            }

            using (StreamWriter sw = File.CreateText(this._pathInfoLocation)) {
                sw.Write(newPath);
            }
        }

        public string GetFilesDirectory() {
            return File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ClipboardTurbo\filepath.txt");
        }

        public void UpdateSettingValue(Setting settingName, string settingValue) {

            SettingsList = _xmlManager.ReadInformation<Configuration>();
            if (settingValue.Equals(String.Empty)) {
                settingValue = "";
            }

            foreach (Configuration config in SettingsList) {

                if(config.Setting == settingName) {
                    switch (settingName) {

                        case Setting.KeyboardShortcut:
                            SettingsList.First<Configuration>(item => item.Setting == Setting.KeyboardShortcut).Value = settingValue;
                            _xmlManager.WriteInformation(SettingsList);
                            break;
                        case Setting.KeepWindowOnTop:
                            SettingsList.First<Configuration>(item => item.Setting == Setting.KeepWindowOnTop).Value = settingValue;
                            _xmlManager.WriteInformation(SettingsList);
                            break;
                        case Setting.StartWithWindows:
                            SettingsList.First<Configuration>(item => item.Setting == Setting.StartWithWindows).Value = settingValue;
                            _xmlManager.WriteInformation(SettingsList);
                            break;
                    }
            
                }

            }

        }

        public string GetHotKeySettingValue() {
            SettingsList = _xmlManager.ReadInformation<Configuration>();
            string value = SettingsList.First<Configuration>(item => item.Setting == Setting.KeyboardShortcut).Value;

            return value;
        }

    }
}
