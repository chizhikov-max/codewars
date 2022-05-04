using System;
using System.Linq;

public class Kata
{
    public static bool Narcissistic(int value)
    {
        var str = value.ToString();
        int power = str.Length;
        var sum = Convert.ToInt64(str.Sum(x => Math.Pow(double.Parse(x.ToString()), power)));
        return sum == value;
    }
}