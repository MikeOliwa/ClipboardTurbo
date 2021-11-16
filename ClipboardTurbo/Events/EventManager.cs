using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardTurbo.Events {
    public sealed class EventManager {

        //Fields
        private static EventManager EventManagerInstance = null;
        public event EventHandler<UIState> UIStateChangedEvent;
        public event EventHandler EmptyWholeListClickedEvent;
        public event EventHandler<KeyboardShortcutChangedEventArgs> KeyboardShortcutChangedEvent;

        //Contructor
        private EventManager() {
        }

        //Factory method
        public static EventManager Instance {
            get {
                if(EventManagerInstance == null) {
                    EventManagerInstance = new EventManager();
                }
                return EventManagerInstance;
            }
            set { 
            
            }
        }

        //Event-Raiser
        public void RaiseUIStateChangedEvent(UIState state) {
            this.UIStateChangedEvent?.Invoke(this, state);
        }

        public void RaiseEmptyWholeListClickedEvent() {
            EmptyWholeListClickedEvent?.Invoke(this, EventArgs.Empty);
        }

        public void RaiseKeyboardShortcutChangedEvent(KeyboardShortcutChangedEventArgs e) {
            KeyboardShortcutChangedEvent?.Invoke(this, e);
        }

    }
}
