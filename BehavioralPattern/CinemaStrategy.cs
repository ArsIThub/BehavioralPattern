namespace BehavioralPattern
{
    public class CinemaStrategy : ILightningStrategy
    {
        public void Apply() 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Lets watch cinema");
            Console.ResetColor();
        }
    }
}
