using System;

namespace tttttttttt
{
    class Program
    {
        static void Main(string[] args)
        {
            int decNum = 0;

            int i = 0;
            int rem = 0;

            string hexNum = "";

            Console.Write("Enter a Decimal Number :");
            decNum = int.Parse(Console.ReadLine());

            while (decNum != 0)
            {
                rem = decNum % 16;
                if (rem < 10)
                    rem = rem + 48;
                else
                    rem = rem + 55;

                hexNum += Convert.ToChar(rem);
                decNum = decNum / 16;
            }

            Console.Write("Hexa-decimal number :");
            for (i = hexNum.Length - 1; i >= 0; i--)
                Console.Write(hexNum[i]);

        }
    }
}
