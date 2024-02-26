namespace lab8._2
{
    public class Bai2
    {
        static object syncObj1 = new object();
        static object syncObj2 = new object();

        static void Poo()
        {
            Console.WriteLine("Inside Foo method");
            lock (syncObj1)
            {
                Console.WriteLine("Foo: lock(syncObj1)");
                Thread.Sleep(100);
                lock (syncObj2)
                {
                    Console.WriteLine("Foo : lock(syncObj2)");
                }
            }
        }

        static void Bar()
        {
            Console.WriteLine("Inside Bar method");
            lock (syncObj2)
            {
                Console.WriteLine("Bar: lock(syncObj2)");
                Thread.Sleep(100);
                if (Monitor.TryEnter(syncObj2, 1000)) // sử dụng Monitor.TryEnter(syncObj2, 1000) để thử khóa syncObj2 trong 1 giây. Nếu thành công, chúng ta thực hiện một khối lock bên trong với đối tượng đồng bộ syncObj1
                {
                    try
                    {
                        Console.WriteLine("Bar: lock(syncObj1)");
                    }
                    finally
                    {
                        Monitor.Exit(syncObj2);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            Thread t1 = new Thread(Poo);
            Thread t2 = new Thread(Bar);

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Main Thread Complered");
            Console.ReadKey();
        }
    }
}