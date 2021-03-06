using System.Collections.Generic;
using System.Diagnostics;

namespace CocosSharp
{
    public class CCColor3BWapper 
    {
        private CCColor3B color;

        public CCColor3BWapper(CCColor3B xcolor)
        {
            color = xcolor;
        }

        public CCColor3B Color
        {
            get { return color; }
        }
    }

    public enum CCBValueType
    {
        Int,
        Float,
        Bool,
        UnsignedChar,
        String,
        Array
    }

    public class CCBValue 
    {
        private float floatValue;
        private CCBValueType _type;
        private int intValue;
        private string _strValue;
        private object _arrValue;  

        public CCBValue (int value)
        {
            intValue = value;
            _type = CCBValueType.Int;
        }

        public CCBValue(bool value)
        {
            intValue = value ? 1 : 0;
            _type = CCBValueType.Bool;
        }

        public CCBValue(float value)
        {
            floatValue = value;
            _type = CCBValueType.Float;
        }

        public CCBValue(byte value)
        {
            intValue = value;
            _type = CCBValueType.UnsignedChar;
        }

        public CCBValue(string value)
        {
            _strValue = value;
            _type = CCBValueType.String;
        }

        public CCBValue(object value)
        {
            _arrValue = value;
            _type = CCBValueType.Array;
        }

        public int GetIntValue()
        {
            Debug.Assert(_type == CCBValueType.Int, "The type of CCBValue isn't integer.");
            return intValue;
        }

        public float GetFloatValue()
        {
            Debug.Assert(_type == CCBValueType.Float, "The type of CCBValue isn't float.");
            return floatValue;
        }

        public bool GetBoolValue()
        {
            Debug.Assert(_type == CCBValueType.Bool, "The type of CCBValue isn't boolean.");
            return intValue == 1;
        }

        public byte GetByteValue()
        {
            Debug.Assert(_type == CCBValueType.UnsignedChar, "The type of CCBValue isn't unsigned char.");
            return (byte) intValue;
        }

        public string GetStringValue()
        {
            Debug.Assert(_type == CCBValueType.String, "The type of CCBValue isn't string.");
            return _strValue;
        }

        public object GetArrayValue()
        {
            Debug.Assert(_type == CCBValueType.Array, "The type of CCBValue isn't array.");
            return _arrValue;
        }

        public CCBValueType Type
        {
            get { return _type; }
        }
    }
}