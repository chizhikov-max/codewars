using System;

public static class Kata {
  
    public static int JumpTo(int x, int y) {
        int count = 0;
        while (x != y)
        {
            if (y % 2 == 0)
            {
                y /= 2;
                if (x <= y)
                {
                    count++;
                    continue;
                }
                y *= 2;
            }

            y--;
            count++;
        }
        return count;
    }
}