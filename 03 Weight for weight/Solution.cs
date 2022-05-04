using System;
using System.Collections.Generic;
using System.Linq;

public class Number
{
    public Number(long value)
    {
        Value = value;
    }

    public long Value { get; set; }

    public string StringValue => Value.ToString();

    public long Weight
    {
        get
        {
            var strValue = Value.ToString();
            var weight = strValue.Sum(x => long.Parse(x.ToString()));
            return weight;
        }
    }

    private sealed class ValueRelationalComparer : IComparer<Number>
    {
        public int Compare(Number x, Number y)
        {
            if (x.Weight > y.Weight) return 1;
            if (x.Weight < y.Weight) return -1;
            return String.CompareOrdinal(x.StringValue, y.StringValue);
        }
    }

    public static IComparer<Number> ValueComparer { get; } = new ValueRelationalComparer();

    public override string ToString()
    {
        return StringValue;
    }
}

public class WeightSort {
  
    public static string orderWeight(string strng) {
        var numbers = strng.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => new Number(long.Parse(x)));
        var orderedNumbers = numbers.OrderBy(x => x, Number.ValueComparer);
        return string.Join(" ", orderedNumbers);
    }
}