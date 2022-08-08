// Нужно определить обработку исключения в самом асинхронном методе (в случае асинхронного void-метода). 

OperationAsync("Very long text");
OperationAsync("Short");

async void OperationAsync(string message)
{
    try
    {
        if (message.Length < 6)
        {
            throw new ArgumentException($"Invalid string length: {message.Length}");            
        }
        else Console.WriteLine(message + " << has been accepted!");

        await Task.Delay(3000);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}