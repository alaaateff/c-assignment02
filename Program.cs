namespace secondproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1)
            Console.WriteLine("Please enter number");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 4 == 0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            #endregion

           



        }
    }
}
