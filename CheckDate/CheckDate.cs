using System;

namespace CheckDate
{
    public class ChechDate
    {
        public static void CheckDate()
        {
            //DateTime date = DateTime.Now;
            //int remainder = date.Day % 2;
            if (DateTime.Now.Day % 2 == 0)
                Console.WriteLine("Четная");
            else
                Console.WriteLine("Нифига");
        }    
    }
}
