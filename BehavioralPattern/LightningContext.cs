namespace BehavioralPattern
{
    public class LightningContext
    {
        private ILightningStrategy _strategy;

        public LightningContext(ILightningStrategy initialStrategy) => _strategy = initialStrategy;

        public void SetStrategy(ILightningStrategy newtrategy) => _strategy = newtrategy;

        public void ExecuteAlgorithm() => _strategy.Apply();
    }
}
