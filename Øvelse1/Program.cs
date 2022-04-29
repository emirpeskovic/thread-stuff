// Create thread that prints specific text 5 times
Thread thread = new(delegate()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("C#-trådning er nemt!");
    }
});

// Start thread
thread.Start();