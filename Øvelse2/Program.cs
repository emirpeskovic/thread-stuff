// Create first thread that prints something specific
Thread t1 = new(delegate ()
{
    for (int i = 0; i < 5; i++)
    {
        // Print
        Console.WriteLine("C#-trådning er nemt!");

        // Sleep for 1 second
        Thread.Sleep(1000);
    }
});

// Create second thread that prints something specific
Thread t2 = new(delegate ()
{
    for (int i = 0; i < 5; i++)
    {
        // Print
        Console.WriteLine("Også med flere tråde ...");

        // Sleep for 1 second
        Thread.Sleep(1000);
    }
});

// Start threads
t1.Start();
t2.Start();

// Q: Er det smart at benytte Thread.Sleep(1000);?
// A: Nej, det er ikke smart. Thread.Sleep(1000); vil kunne gå over for tid, hvis der er mere tid tilbage.