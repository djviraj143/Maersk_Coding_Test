using System;

namespace Maersk_Coding_Test
{
    public class Item
    {
        public string Id { get; set; }
        public decimal UnitPrice { get; set; }

        public Item(string value)
        {
            this.Id = value;

            switch (value)
            {
                case "A":
                    this.UnitPrice = 50m;
                    break;
                case "B":
                    this.UnitPrice = 30m;
                    break;
                case "C":
                    this.UnitPrice = 20m;
                    break;
                case "D":
                    this.UnitPrice = 15m;
                    break;
            }
        }
    }
}