namespace Lesson10Tasks.Models
{
    static class Task1
    {
        public static void Task1Main(string fraction)
        {
            //fration un doğruluğunu yoxlayaq
            if (string.IsNullOrEmpty(fraction) ||
                !fraction.Contains("/") ||
                fraction.Any(char.IsLetter) ||
                !IsValidFraction(fraction))
            {
                Console.WriteLine("Səhv: Kəsr formatı yanlışdır.");
            }
            else
            {
                string simplifiedFraction = SimplifyFraction(fraction);
                Console.WriteLine($"{fraction} = {simplifiedFraction}"); // Nəticə: 12/24 = 1/2
            }
        }

        static bool IsValidFraction(string fraction)
        {
            string[] parts = fraction.Split('/');
            if (parts.Length != 2)
                return false;

            // Hər iki hissənin tam ədəd olub olmadığını yoxla
            bool isValidNumerator = int.TryParse(parts[0], out int numerator);
            bool isValidDenominator = int.TryParse(parts[1], out int denominator);

            return isValidNumerator && isValidDenominator && denominator != 0;
        }

        static string SimplifyFraction(string fraction)
        {
             // Kəsri surət və məxrəcə bölək
            string[] parts = fraction.Split('/');
            int numerator = int.Parse(parts[0]);// Surət
            int denominator = int.Parse(parts[1]);// Məxrəc
            // ƏBOB (GCD)
            int gcd = GCD(numerator, denominator);
            // Surət və məxrəci ƏBOB a bölmək
            numerator /= gcd;
            denominator /= gcd;
             // Sadələşdirilmiş kəsri qaytaraq
            return $"{numerator}/{denominator}";
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}