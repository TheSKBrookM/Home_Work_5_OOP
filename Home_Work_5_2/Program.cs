namespace Home_Work_5_2
{
    internal class Program
    {
        static void Main()
        {
            MyMatrix matrix = new MyMatrix(4,5);
            matrix.ShowMatrix();

            matrix.ChangeSize(5,4);

            Console.WriteLine(new string('-', 20));

            matrix.ShowMatrix();

            Console.ReadKey();
        }
    }
}