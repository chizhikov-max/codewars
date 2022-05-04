public class ProdFib {
    public static ulong[] productFib(ulong prod) {
        ulong a = 0;
        ulong b = 1;

        while (true)
        {
            var multi = a * b;
            if (multi == prod)
                return new ulong[] { a, b, 1 };
            if (multi > prod)
                return new ulong[] { a, b, 0 };

            var sum = a + b;
            a = b;
            b = sum;
        }
    }
}