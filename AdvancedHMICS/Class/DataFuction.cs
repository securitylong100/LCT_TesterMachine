using System;
using System.Linq;

namespace AdvancedHMICS.Class
{
    public static class DataFuction
    {
        public static string ToBinary(int n)
        {
            if (n < 2) return n.ToString();

            var divisor = n / 2;
            var remainder = n % 2;

            return ToBinary(divisor) + remainder;
        }

        public static string ToFloatType(this string strFloat, FloatType floatType)
        {
            if (strFloat.Length > 4 && UInt32.TryParse(strFloat, out UInt32 value))
            {
                byte[] convertedBytes = new byte[4];
                byte[] bytes = BitConverter.GetBytes(value);
                switch (floatType)
                {
                    case FloatType.FloatSwap:
                        return BitConverter.ToSingle(bytes.Reverse().ToArray(), 0).ToString();
                    case FloatType.FloatReverse:
                        convertedBytes[0] = bytes[2];
                        convertedBytes[1] = bytes[3];
                        convertedBytes[2] = bytes[0];
                        convertedBytes[3] = bytes[1];
                        return BitConverter.ToSingle(convertedBytes, 0).ToString();
                    case FloatType.LittleEndian:
                        convertedBytes[0] = bytes[1];
                        convertedBytes[1] = bytes[0];
                        convertedBytes[2] = bytes[3];
                        convertedBytes[3] = bytes[2];
                        return BitConverter.ToSingle(convertedBytes, 0).ToString();
                    case FloatType.LittleEndianByteSwap:
                        convertedBytes[0] = bytes[1];
                        convertedBytes[1] = bytes[0];
                        convertedBytes[2] = bytes[3];
                        convertedBytes[3] = bytes[2];
                        return BitConverter.ToSingle(convertedBytes.Reverse().ToArray(), 0).ToString();
                    case FloatType.Float:
                    default:
                        break;
                }
            }
            return strFloat;
        }
    }

    public enum FloatType
    {
        Float = 0,
        FloatSwap = 1,
        FloatReverse = 2,
        LittleEndian = 3,
        LittleEndianByteSwap = 4,
    }
}
