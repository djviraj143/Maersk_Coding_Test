using System;
using System.Collections.Generic;

namespace Maersk_Coding_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            Console.WriteLine("Enter the total number of order value");
            int value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("Select the type of item: A, B, C or D");
                string type = Console.ReadLine();
                Item itm = new Item(type);
                items.Add(itm);
            }

            var totalUnitPrice = GetTotalUnitPrice(items);
            Console.WriteLine(totalUnitPrice);
            Console.ReadLine();
        }

        private static int GetTotalUnitPrice(List<Item> items)
        {
            int amountOfItemA = 50;
            int amountOfItemB = 30;
            int amountOfItemC = 20;
            int amountOfItemD = 15;

            int countOfA = 0;
            int countOfB = 0;
            int countOfC = 0;
            int countOfD = 0;

            foreach (Item im in items)
            {
                if (im.Id == "A" || im.Id == "a")
                {
                    countOfA = countOfA + 1;
                }
                if (im.Id == "B" || im.Id == "b")
                {
                    countOfB = countOfB + 1;
                }
                if (im.Id == "C" || im.Id == "c")
                {
                    countOfC = countOfC + 1;
                }
                if (im.Id == "D" || im.Id == "d")
                {
                    countOfD = countOfD + 1;
                }
            }

            int totalAmountOfA = (countOfA / 3) * 130 + (countOfA % 3 * amountOfItemA);
            int totalAmountOfB = (countOfB / 2) * 45 + (countOfB % 2 * amountOfItemB);
            int totalAmountOfC = (countOfC * amountOfItemC);
            int totalAmountOfD = (countOfD * amountOfItemD);
            
            var totalAmount = totalAmountOfA + totalAmountOfB + totalAmountOfC + totalAmountOfD;
            return totalAmount;

        }
    }
}
