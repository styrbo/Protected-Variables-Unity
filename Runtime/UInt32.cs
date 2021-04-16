using System;
using Random = UnityEngine.Random;

namespace Sarteck.ProtectedVariables
{
    [Serializable]
    public struct UIntProtected
    {
        public UIntProtected(uint value = 0)
        {
            _salt = (byte)Random.Range(0, 255);
            _offset = value + _salt;
        }
        
        private uint _offset;
        private byte _salt;

        public uint Value => _offset - _salt;

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