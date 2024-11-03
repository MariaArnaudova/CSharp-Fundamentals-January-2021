using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> allBoxes = new List<Box>();

            while (input != "end")
            {
                string[] data = input.Split();
                // : {Serial Number} {Item Name} {Item Quantity} {itemPrice}
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice;

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Quantity = itemQuantity;
                box.Item = item;

                allBoxes.Add(box);

                input = Console.ReadLine();
            }
            List<Box> descending = allBoxes.OrderByDescending(allBoxes => allBoxes.PriceBox).ToList();

            foreach (Box currentBox in descending)
            {
                Console.WriteLine($"{currentBox.SerialNumber}");
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:F2}: { currentBox.Quantity}");
                Console.WriteLine($"-- ${ currentBox.PriceBox:F2}");
            }
        }
    }


    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Box
    {
        //public Box()
        //{
        //    Item = new Item();

        //}

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox
        {
            get
            {
                return Item.Price * Quantity;
            }
        }
    }
}
