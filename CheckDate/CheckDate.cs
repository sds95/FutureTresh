using System;

namespace CheckDate
{
    public class ChechDate
    {
        public static DateTime date = DateTime.Now;

        public static void CheckDate()
        {
            double remainder = date.Day % 2;
            if (remainder == 0)
                Console.WriteLine("Четная");
            else
                Console.WriteLine("Нифига");
        }    
    }
}
