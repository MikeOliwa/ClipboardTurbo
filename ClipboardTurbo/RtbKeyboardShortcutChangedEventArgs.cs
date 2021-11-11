using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardTurbo {
   public class RtbKeyboardShortcutChangedEventArgs {

        public RtbKeyboardShortcutChangedEventArgs(Keys modifier, char key, string settingValue){
            Modifier = modifier;
            Key = key;
            SettingValue = settingValue;
        }

        public Keys Modifier;
        public char Key;
        public string SettingValue;
   }
}
