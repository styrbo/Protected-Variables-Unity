using System;
using Random = UnityEngine.Random;

namespace Sarteck.ProtectedVariables
{
    [Serializable]
    public struct IntProtected
    {
        public IntProtected(int value = 0)
        {
            _salt = (byte)Random.Range(0, 255);
            _offset = value + _salt;
        }
        
        private int _offset;
        private byte _salt;

        public int Value => _offset - _salt;

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator int(IntProtected value)
        {
            return value.Value;
        }
        
        public static implicit operator IntProtected(int value)
        {
            return new IntProtected(value);
        }
    }
}