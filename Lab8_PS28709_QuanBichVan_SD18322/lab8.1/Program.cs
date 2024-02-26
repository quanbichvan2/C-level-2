namespace lab8._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var x = random.Next(1, 20);
            Thread thread1 = new Thread(() =>
            {

                for (int i = 0; i <= 100; i++)
                {
                    x = random.Next(1, 20);
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    Console.WriteLine($"thread 1: {x}");
                }
            });
            Thread thread2 = new Thread(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    Console.WriteLine($"thread 2: {Math.Pow(x, 2)}");
                }
            });
            thread1.Start();
            thread2.Start();
            Console.ReadLine();
        }
    }
}