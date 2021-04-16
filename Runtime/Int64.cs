using System;
using Random = UnityEngine.Random;

namespace Sarteck.ProtectedVariables
{
    namespace Sarteck.ProtectedVariables
    {
        namespace Sarteck.ProtectedVariables
        {
            [Serializable]
            public struct LongProtected
            {
                public LongProtected(long value = 0)
                {
                    _offset = (byte)Random.Range(0, 255);
                    _value = value + _offset;
                }
        
                private long _value;
                private byte _offset;

                public long Value => _value - _offset;

                public override string ToString()
                {
                    return Value.ToString();
                }

                public static implicit operator long(LongProtected value)
                {
                    return value.Value;
                }
        
                public static implicit operator LongProtected(long value)
                {
                    return new LongProtected(value);
                }
            }
        }
    }
}