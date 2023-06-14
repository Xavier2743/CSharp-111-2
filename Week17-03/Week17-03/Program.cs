Thread t1 = new Thread(MyBackgroundTask);
Thread t2 = new Thread(MyBackgroundTask);
Thread t3 = new Thread(MyBackgroundTask);

t1.Start("X");
t2.Start("Y");
t3.Start("Z");

t1.Join();
t2.Join();
t3.Join();

for (int i = 0; i < 100; i++)
{
    Console.Write(".");
}

static void MyBackgroundTask(object str)
{
    for (int i = 0; i < 100; i++)
    {
        Console.Write(str);
    }
}