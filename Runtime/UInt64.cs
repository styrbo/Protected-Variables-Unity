using System;
using Random = UnityEngine.Random;

namespace Sarteck.ProtectedVariables
{
    [Serializable]
    public struct ULongProtected
    {
        public ULongProtected(ulong value = 0)
        {
            _offset = (byte)Random.Range(0, 255);
            _value = value ^ _offset;
        }
        
        private ulong _value;
        private byte _offset;

        public ulong Value => _value ^ _offset;

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator ulong(ULongProtected value)
        {
            return value.Value;
        }
        
        public static implicit operator ULongProtected(ulong value)
        {
            return new ULongProtected(value);
        }
    }
}