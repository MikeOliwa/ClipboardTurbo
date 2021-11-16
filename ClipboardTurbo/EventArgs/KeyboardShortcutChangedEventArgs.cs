using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardTurbo {
   public class KeyboardShortcutChangedEventArgs {

        //Fields
        public Keys Modifier;
        public char Key;
        public string SettingValue;

        //Constructor
        public KeyboardShortcutChangedEventArgs(Keys modifier, char key, string settingValue){
            Modifier = modifier;
            Key = key;
            SettingValue = settingValue;
        }

   }
}
