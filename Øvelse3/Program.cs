int celcius = 0;

// Create thread that will run until celcius goes below the threshold thrice
Thread t1 = new(delegate ()
{
    // Create random number generator
    Random random = new Random();

    // Bool to check if the loop should continue
    bool terminate = false;

    // Count alarms
    int alarms = 0;

    // Loop until terminate is true
    while (!terminate)
    {
        // Wait 2 seconds until next iteration
        Thread.Sleep(2000);

        // Generate random number for celcius and print it out
        celcius = random.Next(-20, 120);
        Console.WriteLine("[INFO] Temperature: {0}", celcius);

        // Check threshold and increment alarm count if necessary
        if (celcius > 100 || celcius < 0)
        {
            alarms++;
            Console.WriteLine("[ALARM] Temperature went below or above the allowed threshold!");
        }

        // Check if the loop should terminate based on alarms
        if (alarms > 2)
        {
            terminate = true;
        }
    }
});

// Create thread that will run every 10 seconds until the first thread is terminated
Thread t2 = new(delegate ()
{
    // bool to check if the loop should continue
    bool terminate = false;

    while (!terminate)
    {
        // Wait 10 seconds until next iteration
        Thread.Sleep(10000);

        // Check if the first thread is terminated, and if so, terminate the second thread after printing a message
        if (!t1.IsAlive)
        {
            Console.WriteLine("[INFO] Alarm thread was terminated!");
            terminate = true;
        }
    }
});

// Start both threads
t1.Start();
t2.Start();