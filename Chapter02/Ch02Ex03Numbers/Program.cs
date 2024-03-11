string hyphens = new string('-', 110);
string format = "{0,-10}{1,-20}{2,30}{3,50}";
WriteLine($"{hyphens}");
WriteLine(format, "Type", "Byte(s) of memory", "Min", "Max");
WriteLine(hyphens);
WriteLine(format, "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
WriteLine(format, "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
WriteLine(format, "short", sizeof(short), short.MinValue, short.MaxValue);
WriteLine(format, "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
WriteLine(format, "int", sizeof(int), int.MinValue, int.MaxValue);
WriteLine(format, "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
WriteLine(format, "long", sizeof(long), long.MinValue, long.MaxValue);
WriteLine(format, "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
unsafe
{
    WriteLine(format, "Int128", sizeof(Int128), Int128.MinValue, Int128.MaxValue);
    WriteLine(format, "UInt128", sizeof(UInt128), UInt128.MinValue, UInt128.MaxValue);
    WriteLine(format, "Half", sizeof(Half), Half.MinValue, Half.MaxValue);
}
WriteLine(foramt, "float", sizeof(float), float.MinValue, float.MaxValue);
WriteLine(format, "double", sizeof(double), double.MinValue, double.MaxValue);
WriteLine(format, "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
