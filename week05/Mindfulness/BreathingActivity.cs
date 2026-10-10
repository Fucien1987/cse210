public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slow. Clear your mind and focus on your breathing."
        )
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}