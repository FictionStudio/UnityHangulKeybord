using UnityEngine;
using System.Collections;

namespace VirtualKeyBoard
{
    public class VirtualKey : MonoBehaviour
    {
        static public VirtualKeyboard _Keybord = null;
        public enum kType { kCharacter, kOther, kReturn, kSpace, kBackspace, kShift, kTab, kCapsLock, kHangul }
        public char KeyCharacter;
        public kType KeyType = kType.kCharacter;

        private bool mKeepPresed;
        public bool KeepPressed
        {
            set { mKeepPresed = value; }
            get { return mKeepPresed; }
        }

        void Start()
        {
            UnityEngine.UI.Button _button = gameObject.GetComponent<UnityEngine.UI.Button>();
            if (_button != null)
            {
                _button.onClick.AddListener(onKeyClick);
            }
        }

        void onKeyClick()
        {
            if (_Keybord != null)
            {
                _Keybord.KeyDown(this);
            }
        }
    }
}