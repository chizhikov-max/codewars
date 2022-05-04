using System;
using System.Collections.Generic;

public class Kata
{
    public static string PigIt(string str)
    {
        var result = new List<string>();
        var parts = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var part in parts)
        {
            var firstLetter = part[0];
            if (char.IsLetter(firstLetter))
            {
                string item = $"{part.Remove(0, 1)}{firstLetter}ay";
                result.Add(item);
            }
            else
            {
                result.Add(part);
            }
        }
        return String.Join(" ", result);  }
}