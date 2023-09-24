namespace AutoEatery.Util;

public static class Extensions
{
    public static decimal NextDecimal(this Random random, decimal start, decimal end)
    {
        return (decimal)random.NextDouble() * (end - start) + start;
    }

    public static double NextDouble(this Random random, double start, double end)
    {
        return random.NextDouble() * (end - start) + start;
    }
}