namespace MVVMClicker.Model
{
    internal sealed class CoinModel : ICoinModel
    {
        public float CurrentCoin { get; set; }

        public CoinModel()
        {
            CurrentCoin = 0;
        }
    }
}
