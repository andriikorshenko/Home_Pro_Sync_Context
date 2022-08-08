using Task_002;

Info();

SynchronizationContext.SetSynchronizationContext(new CustomSynchronizationContext());

Task task1 = Task.Run(() => Factorial(3));
await task1;

Task task2 = task1.ContinueWith(t => Console.WriteLine("Continue with method!"));
task2.Wait();

Info();

void Factorial(int number)
{
    int sum = number;

    while (number > 1)
    {
        sum *= --number;
    }
    Console.WriteLine("The result is : " + sum);
}

void Info()
{
    Console.WriteLine("Id: "
        + Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine("Name: "
        + Thread.CurrentThread.Name);
    Console.WriteLine("IsThreadPoolThread: "
        + Thread.CurrentThread.IsThreadPoolThread);
}