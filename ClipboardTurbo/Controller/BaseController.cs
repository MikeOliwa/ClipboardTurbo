using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardTurbo.Controller {
    public class BaseController {

        //Fields
        protected string _pathInfoLocation2 = @"C:\Users\\mikea\AppData\Roaming\ClipboardTurbo\filepath.txt";
        protected string _pathInfoLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ClipboardTurbo";
        protected string _dataFilePath;
        protected string _dataFileName;
        public XmlManager _xmlManager;

        //Constructor
        public BaseController(string filePath, string fileName) {
            _xmlManager = new XmlManager(Path.Combine(filePath, fileName));
            _dataFilePath = filePath;
            _dataFileName = fileName;

            _xmlManager.PrepareXmlFolder(_dataFilePath);
        }

    }
}
