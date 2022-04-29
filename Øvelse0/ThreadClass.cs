namespace Øvelse0
{
    public class ThreadClass
    {
        
        // Writes "Simple Thread" out to the console 5 times
        public void WorkThreadFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(string.Format("Thread named '{0}' is running", Thread.CurrentThread.Name));
            }
        }
    }
}
