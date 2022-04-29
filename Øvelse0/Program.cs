using Øvelse0;

// Creates instance of ThreadClass
ThreadClass tc = new();

// Creates thread 1
Thread t1 = new(tc.WorkThreadFunction);
t1.Name = "First Worker";
t1.Priority = ThreadPriority.Normal;

// Creates thread 2
Thread t2 = new(tc.WorkThreadFunction);
t2.Name = "Second Worker";
t2.Priority = ThreadPriority.Highest;

// Starts thread 1 and thread 2
t1.Start();
t2.Start();

// Waits for input to end main thread
Console.Read();