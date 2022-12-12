using System.ComponentModel;

namespace Home_Work_5_3
{
    internal class Program
    {
        static void Main()
        {
            Store shop = new Store(3);

            Console.WriteLine("In stock:");
            shop.AddItem(new Article("Laptop", "Foxtrot", 35000.00), 0);
            shop.AddItem(new Article("Fridge", "Samsung", 18000.00), 1);
            shop.AddItem(new Article("TV", "Eldorado", 15000.00), 2);

            shop.Show();
            Console.WriteLine(new string('-', 20));

            Console.Write("Write index of item: ");
            int index = Int32.Parse(Console.ReadLine());

            Console.WriteLine(shop[index]);
            Console.WriteLine(new string('-', 20));

            Console.Write("Write what you want to buy: ");
            string item = Console.ReadLine();

            Console.WriteLine(shop[item]); 
            Console.WriteLine(new string('-', 20));

            Console.ReadKey();
        }
    }
}