using System;
using MVVMClicker.Model;

namespace MVVMClicker.ViewModel
{
    public interface ICoinViewModel 
    {
        ICoinModel CoinModel { get; }

        IBonusCoinModel BonusCoinModel { get; }

        void GetCoin(float value);

        void UpgradeCoin();

        event Action<float> OnCoinChange;
    }
}
