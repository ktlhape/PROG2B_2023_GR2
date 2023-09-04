using System.ComponentModel;
using System.Threading.Tasks;
namespace AsyncPrograming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TaskOptions
            //Option 1
            //Task taskOdd = new Task(OddNumbers);
            //Task taskEven = new Task(EvenNumbers);
            //taskOdd.Start();
            //taskEven.Start();

            //Option 2
            //Task oddTask = Task.Run(() => OddNumbers());
            //Task evenTask = Task.Run(() => EvenNumbers());

            //Task otherTask = Task.Run(() => {
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        if (i %3 ==0)
            //        {
            //            Console.WriteLine(i);
            //        } 
            //    }

            //});

            //Option 3

            //Task.Run(() => OddNumbers());
            //Task.Run(() => EvenNumbers());
            //Task.Run(() =>
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //});

            #endregion

            Task taskOdd = OddNumbers();
            Task taskEven = Task.Run(() => EvenNumbers());
            //Task.WaitAll(taskOdd);
            DisplaySum();

            Console.Read();
        }
        static void Test()
        {

        }

        static async Task OddNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(2000);
                if (i %2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static async Task EvenNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(2000);
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int GetSum()
        {
            Thread.Sleep(5000);
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            return sum;
        }
        static async void DisplaySum()
        {
            Task<int> taskSum = new Task<int>(GetSum);
            taskSum.Start();
            Console.WriteLine("Busy calculating the sum...");
            int sum = await taskSum;
            Console.WriteLine($"Sum: {sum}");
        }
      
    }
}