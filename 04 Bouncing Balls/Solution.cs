public class BouncingBall 
{
    public static int BouncingBall(double h, double bounce, double window) {
        if (h <= 0) return -1;
        if (bounce <= 0 || bounce >= 1) return -1;
        if (window >= h) return -1;
    
        int counter = 0;

        while (h > window)
        {
            counter++;
            h *= bounce;
            if (h > window)
                counter++;
        }

        return counter;
    }
}