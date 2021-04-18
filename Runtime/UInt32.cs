using System;
using Random = UnityEngine.Random;

namespace Sarteck.ProtectedVariables
{
    [Serializable]
    public struct UIntProtected
    {
        public UIntProtected(uint value = 0)
        {
            _offset = (byte)Random.Range(0, 255);
            _value = value ^ _offset;
        }
        
        private uint _value;
        private byte _offset;

        public uint Value => _value ^ _offset;

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator uint(UIntProtected value)
        {
            return value.Value;
        }
        
        public static implicit operator UIntProtected(uint value)
        {
            return new UIntProtected(value);
        }
    }
}