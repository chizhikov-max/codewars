using System;
using System.Linq;

public class Persist 
{
    public static int Persistence(long n) 
    {
        int count = 0;
        while (true)
        {
            var s = n.ToString();
            if (s.Length == 1) break;
                
            var numbers = s.Select(x => long.Parse(x.ToString()));
            n = numbers.Aggregate((a, b) => a * b);
            count++;

            if (n.ToString().Length == 1)
                break;
        }

        return count;
    }
}