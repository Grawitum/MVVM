using System;
using MVVMClicker.Model;

namespace MVVMClicker.ViewModel
{
    public class CoinViewModel : ICoinViewModel
    {
        public event Action<float> OnCoinChange;
        public ICoinModel CoinModel { get; }

        public IBonusCoinModel BonusCoinModel { get; }

        public CoinViewModel(ICoinModel coinModel, IBonusCoinModel bonusCoinModel)
        {
            CoinModel = coinModel;
            BonusCoinModel = bonusCoinModel;
        }


        public void GetCoin(float value)
        {
            CoinModel.CurrentCoin += value + (1 * BonusCoinModel.BonusCoin);

            OnCoinChange?.Invoke(CoinModel.CurrentCoin);
        }

        public void UpgradeCoin()
        {
            if(CoinModel.CurrentCoin >= BonusCoinModel.BonusCoin)
            {
                CoinModel.CurrentCoin -= BonusCoinModel.BonusCoin;
                OnCoinChange?.Invoke(CoinModel.CurrentCoin);

                BonusCoinModel.BonusCoin++;

            }
        }

    }
}
