namespace Utils
{
    using System;

    public class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static bool Factorial(int n, out int answer)
        {
            int k;// Loop counter
            int f = 1;// Working value
            bool ok = true; // True if okay, false if not


            if (n < 0)
            {
                ok = false;
            }

            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception) // Check for exceptions
            {
                f = 0;
                ok = false;
            }
            answer = f;
            
            return ok;
        }
    }
}      
