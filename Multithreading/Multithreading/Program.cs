namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Offload the methods from the Main Thread
            Thread thOdd = new Thread(() => OddNumbers(1,10));
            Thread thEven = new Thread(EvenNumbers);
            Thread thSum = new Thread(GetSum);

            //offload a piece of logic from the Main thread
            Thread thOther = new Thread((x) =>
            {
                //logic
            });

            //Execute the start method to start the thread
            thOdd.Start();
            thEven.Start();
            thSum.Start();

            Console.Read();
        }

        static void OddNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Thread.Sleep(2000);
                if (i % 2 !=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void EvenNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(2000);
                if (i % 2 ==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void GetSum()
        {
            Console.WriteLine();
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum is: {sum}");
        }
    }
}