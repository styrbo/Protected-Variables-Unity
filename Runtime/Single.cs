using System;
using Random = UnityEngine.Random;

namespace Sarteck.ProtectedVariables
{
    namespace Sarteck.ProtectedVariables
    {
        [Serializable]
        public struct FloatProtected
        {
            public FloatProtected(float value = 0)
            {
                _offset = (byte)Random.Range(0, 255);
                _value = value * _offset;
            }
        
            private float _value;
            private byte _offset;

            public float Value => _value / _offset;

            public override string ToString()
            {
                return Value.ToString();
            }

            public static implicit operator float(FloatProtected value)
            {
                return value.Value;
            }
        
            public static implicit operator FloatProtected(float value)
            {
                return new FloatProtected(value);
            }
        }
    }
}