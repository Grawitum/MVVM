namespace MVVMClicker.Model
{
    internal sealed class BonusModel : IBonusCoinModel
    {
        public float BonusCoin { get; set; }

        public BonusModel()
        {
            BonusCoin = 0;
        }
    }
}
