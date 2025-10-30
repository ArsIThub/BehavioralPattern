namespace BehavioralPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lightning setup\n");

            var context = new LightningContext(new PartyStrategy());
            context.ExecuteAlgorithm();   

            context.SetStrategy(new CinemaStrategy());
            context.ExecuteAlgorithm();   
        }
    }
}
