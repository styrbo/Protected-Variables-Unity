using System;
using Random = UnityEngine.Random;

namespace Sarteck.ProtectedVariables
{
    [Serializable]
    public struct IntProtected
    {
        public IntProtected(int value = 0)
        {
            _offset = (byte)Random.Range(0, 255);
            _value = value ^ _offset;
        }

        private int _value;
        private byte _offset;

        public int Value => _value ^ _offset;

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