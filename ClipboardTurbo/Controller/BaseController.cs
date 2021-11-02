using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardTurbo.Controller {
    public class BaseController {

        protected string _pathInfoLocation = @"C:\Users\\mikea\AppData\Roaming\ClipboardTurbo\ClipboardTurbo_Path.txt";
        protected string _dataFilePath;
        protected string _dataFileName;
        protected XmlManager _xmlManager;

        public BaseController(string filePath, string fileName) {
            _xmlManager = new XmlManager(Path.Combine(filePath, fileName));
            _dataFilePath = filePath;
            _dataFileName = fileName;

            _xmlManager.PrepareXmlFolder(_dataFilePath);
        }

    }
}
