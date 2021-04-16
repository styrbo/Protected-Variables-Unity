using System;
using Random = UnityEngine.Random;

namespace Sarteck.ProtectedVariables
{
    namespace Sarteck.ProtectedVariables
    {
        [Serializable]
        public class StringProtected
        {
            public StringProtected(string value)
            {
                _offset = (byte)Random.Range(0, 255);
                
                var charArray = new char[value.Length];

                for (var i = 0; i < charArray.Length; i++)
                {
                    charArray[i] = (char)(value[i] >> _offset);
                }
                
                _value = new string(charArray);
            }
        
            private string _value;
            private byte _offset;

            public string Value
            {
                get
                {
                    var charArray = new char[_value.Length];

                    for (var i = 0; i < charArray.Length; i++)
                    {
                        charArray[i] = (char)(_value[i] << _offset);
                    }
                
                    return new string(charArray);
                }
            }

            public override string ToString()
            {
                return Value;
            }

            public static implicit operator string(StringProtected value)
            {
                return value.Value;
            }
        
            public static implicit operator StringProtected(string value)
            {
                return new StringProtected(value);
            }
        }
    }
}