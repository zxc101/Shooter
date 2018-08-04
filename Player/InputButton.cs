using UnityEngine;

namespace Player
{
    public class InputButton
    {
        private byte _attack = 0;

        private KeyCode _flash = KeyCode.F;
        private KeyCode _weapon1 = KeyCode.Alpha1;
        private KeyCode _weapon2 = KeyCode.Alpha2;
        private KeyCode _recharge = KeyCode.R;

        public byte Attack { get { return _attack; } set { _attack = value; } }

        public KeyCode Flash { get { return _flash; } set { _flash = value; } }
        public KeyCode Weapon1 { get { return _weapon1; } set { _weapon1 = value; } }
        public KeyCode Weapon2 { get { return _weapon2; } set { _weapon2 = value; } }
        public KeyCode Recharge { get { return _recharge; } set { _recharge = value; } }
    }
}