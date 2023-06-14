Thread t1 = new Thread(MyBackgroundTask);
t1.Start();
for (int i = 0; i < 100; i++)
{
    Console.Write("A");
}

static void MyBackgroundTask()
{
    for (int i = 0; i < 100; i++)
    {
        Console.Write("B");
    }
}