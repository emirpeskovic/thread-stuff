// Create the char that will be used to store the user's input
char ch = '*';

// Create thread that writes the char to the console
Thread printerThread = new(delegate ()
{
    while (true)
    {
        Console.Write(ch);

        // Sleep for 100 milliseconds, so we don't flood the console
        Thread.Sleep(100);
    }
});

// Create thread that reads the user's input
Thread inputThread = new(delegate ()
{
    while (true)
    {
        // Read the user's input and take the first character of the input and assign it to our 'ch' variable
        // If there is no input (they pressed enter), default back to '*'
        ch = Console.ReadLine()?.ToCharArray()?.FirstOrDefault('*') ?? '*';
    }
});

// Start both threads
printerThread.Start();
inputThread.Start();