using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClipboardTurbo.View;
using ClipboardTurbo.Controller;

namespace ClipboardTurbo.Controller {
    public class ClipboardController{

        List<Information> InformationList;

        public ClipboardController() {

            Clipboard.settingsController.WriteInformation(new List<Information> { new Information {Name = "-", Value = "-" } });
            InformationList = Clipboard.settingsController.ReadInformation();

        }

        public void AddInformation(string name, string value) {
            InformationList = Clipboard.settingsController.ReadInformation();
            InformationList.Add(new Information { Name = name, Value = value });
            Clipboard.settingsController.WriteInformation(InformationList);
        }

        public void RefreshListView(ListView listView) {
            listView.Items.Clear();
            foreach(Information information in InformationList) {
                listView.Items.Add(information.Name + " - " + information.Value);
            }
        }
    } 

}
