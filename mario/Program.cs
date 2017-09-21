using System;

namespace mario
{
    class Program
    {
        static void Main()
        {
            int number;
            do
            {
                Say();
                string height = Console.ReadLine();
                Int32.TryParse(height, out number);
            } while (number < 0 || number > 23);
        }

        public void Say()
        {
            Console.Write("Height:");
        }
    }
}
