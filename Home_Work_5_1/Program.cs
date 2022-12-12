namespace Home_Work_5_1
{
    internal class Program
    {
        static void ShowArrayOddNumber(int[] array)
        {
            Console.Write("Odd number: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write("{0} ", array[i]);
                }
            }
        }
        static void ShowArrayAver(float arrayAver)
        {
            Console.WriteLine("Average: {0}", arrayAver);
        }
        static void ShowArraySum(int arraySum)
        {
            Console.WriteLine("Sum: {0}", arraySum);
        }
        static float ArrayAver(int[] array, int arraySum)
        {
            float arrayAver = (float)arraySum / (float)array.Length;

            return arrayAver;
        }
        static int ArraySum(int[] array)
        {
            int arraySum = 0;
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arraySum += array[i];
                }
            }
            return arraySum;
        }
        static void ShowArrayMax(int[] array)
        {
            Console.WriteLine("Max: {0}", array.Max());
        }
        static void ShowArrayMin(int[] array)
        {
            Console.WriteLine("Min: {0}", array.Min());
        }
        static void RandomFillArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write("{0} ", array[i]);
            }
        }
        static void Main()
        {
            Random random = new Random();

            int r = random.Next(0, 20);
            int[] array = new int[r];

            RandomFillArray(array);

            Console.WriteLine();

            ShowArrayMax(array);

            ShowArrayMin(array);

            int arraySum = ArraySum(array);

            ShowArraySum(arraySum);

            float arrayAver = ArrayAver(array, arraySum);

            ShowArrayAver(arrayAver);

            ShowArrayOddNumber(array);

            Console.ReadKey();
        }
    }
}