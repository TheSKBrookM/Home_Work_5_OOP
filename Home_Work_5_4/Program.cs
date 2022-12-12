namespace Home_Work_5_4
{
    internal class Program
    {
        static void Main()
        {
            Dictionary dictionary = new Dictionary();

            dictionary.Show();
            Console.WriteLine(new string('-', 20));

            while (true)
            {
                Console.Write("Слово для перекладу: ");
                string word = Console.ReadLine();

                Console.WriteLine(dictionary[word.ToLower()]);
            }

            Console.ReadKey();
        }
    }
}