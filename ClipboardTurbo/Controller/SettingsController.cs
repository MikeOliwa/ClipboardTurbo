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

        List<Configuration> SettingsList = new List<Configuration> { };


        private SettingsController(string currentPath)
            : base(currentPath, "ClipboardTurbo_Config.xml") {
        }

        public static SettingsController Create() {
            string currentPath = System.IO.File.ReadAllText(@"C:\Users\\mikea\AppData\Roaming\ClipboardTurbo\filepath.txt");
            var controller = new SettingsController(currentPath);

            if (File.Exists(Path.Combine(controller._dataFilePath, controller._dataFileName))) {
                controller.SettingsList = controller._xmlManager.ReadInformation<Configuration>();
                controller._xmlManager.WriteInformation(controller.SettingsList);
            }
            else {
                controller._xmlManager.WriteInformation(controller.SettingsList);
            }

            return controller;
        }

        public void SetFilesDirectory(string newPath) {

            string currentPath = System.IO.File.ReadAllText(@"C:\Users\\mikea\AppData\Roaming\ClipboardTurbo\filepath.txt");

            List<string> files = Directory.GetFiles(currentPath).ToList();
            foreach (string file in files) {
                if (file.Contains("ClipboardTurbo")) {
                    File.Copy(currentPath + '\\' + file.Substring(file.LastIndexOf('\\')), newPath + '\\' + file.Substring(file.LastIndexOf('\\')));
                    File.Delete(currentPath + '\\' + file.Substring(file.LastIndexOf('\\')));
                }
            }

            using (StreamWriter sw = File.CreateText(this._pathInfoLocation)) {
                sw.Write(newPath);
            }
        }

        public string GetFilesDirectory() {
            return File.ReadAllText(@"C:\Users\\mikea\AppData\Roaming\ClipboardTurbo\filepath.txt");
        }

    }
}
