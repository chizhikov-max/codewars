using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static List<string> Anagrams(string word, List<string> words)
    {
        bool IsAnagram(string x, string y)
        {
            var stringX = new string(x.OrderBy(z => z).ToArray());
            var stringY = new string(y.OrderBy(z => z).ToArray());
            return stringX == stringY;
        }

        var result = new List<string>();
        foreach (var item in words)
        {
            if (IsAnagram(word, item))
                result.Add(item);
        }
        return result;
    }
}