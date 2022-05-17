using System;

namespace IntergralTypes
{
    class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000_0000; // Seven 0
            uint f = 3_0000_0000; // Eight 0

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000; // Eleven 0
            ulong h = 200_0000_0000_0000_0000; // Eighteen 0

            Console.WriteLine($"g={g}, h={h}");

            byte a1 = 240; // Decimal Literals
            Console.WriteLine($"a1={a1}");

            byte b1 = 0b1111_0000; // Binary Literals
            Console.WriteLine($"b1={b1}");

            byte c1 = 0XF0; // Hexadecimal Literals
            Console.WriteLine($"c1={c1}");

            uint d1 = 0x1234_abcd; // Hexadecimal Literals
            Console.WriteLine($"d1={d1}");
        }
    }
}