namespace UsingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 18,11,14,19,25};

            //Using LINQ, get the even numbers

            List<int> evenNumbers = (from num in numbers
                              where num % 2 == 0
                              select num).ToList();

            var oddNumbers = (from num in numbers
                                     where num % 2 != 0
                                     select num);
            Console.WriteLine("Even Numbers");
            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}