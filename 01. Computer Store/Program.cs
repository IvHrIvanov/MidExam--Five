using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            double sum = 0;

            while (input != "special" && input != "regular")
            {
                double prices = double.Parse(input);

                if (prices < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    sum += prices;
                }
                
                input = Console.ReadLine();
            }
            double taxes = sum * 0.2;
          
            double totalSum = 0;
            if(input=="special")
            {
                double specialTaxes = taxes + sum;
                totalSum =specialTaxes- (specialTaxes * 0.10);

            }
            else if(input=="regular")
            {
                totalSum = sum + taxes;
            }

            if (totalSum == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {


                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalSum:f2}$");
            }
        }
    }
}
