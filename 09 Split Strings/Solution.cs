using System.Collections.Generic;

public class SplitString
{
    public static string[] Solution(string str)
    {
        if (str.Length % 2 == 1){
            str+="_";
        }
        var result = new List<string>();
        for (int i=0; i< str.Length; i+=2) {
            result.Add(str.Substring(i,2));
        }
        return result.ToArray();
    }
}