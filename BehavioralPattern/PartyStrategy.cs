namespace BehavioralPattern
{
    public class PartyStrategy : ILightningStrategy
    {
        public void Apply() 
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Party!");
            Console.ResetColor();
        }
    }
}
