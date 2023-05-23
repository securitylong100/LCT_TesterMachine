using System;
using System.Linq;
using System.Runtime.InteropServices;

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

        [StructLayout(LayoutKind.Explicit)]
        struct MyUnion
        {
            [FieldOffset(0)] public byte byte1;
            [FieldOffset(1)] public byte byte2;
            [FieldOffset(2)] public byte byte3;
            [FieldOffset(3)] public byte byte4;
            [FieldOffset(0)] public UInt32 int32Value;
            [FieldOffset(0)] public float floatValue;
        }

        public static float ToFloat(this UInt32 uint32Value)
        {
            if (uint32Value == 0)
            {
                return 0;
            }
            MyUnion u = new MyUnion();
            MyUnion w = new MyUnion();
            u.int32Value = uint32Value;
            w.byte1 = u.byte3;
            w.byte2 = u.byte4;
            w.byte3 = u.byte1;
            w.byte4 = u.byte2;
            return w.floatValue;
        }
    }
}
