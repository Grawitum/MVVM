using MVVMClicker.Model;
using MVVMClicker.View;
using MVVMClicker.ViewModel;
using UnityEngine;

namespace MVVMClicker
{
    internal sealed class Starter : MonoBehaviour
    {
        [SerializeField] private CoinView _coinView;
        [SerializeField] private GetCoinView _getCoinView;
        [SerializeField] private UpgradeCoinView _upgradeCoinView;

        private void Start()
        {
            var coinModel = new CoinModel();
            var bonusCoinModel = new BonusModel();
            var coinViewModel = new CoinViewModel(coinModel,bonusCoinModel);
            _coinView.Initialize(coinViewModel);
            _getCoinView.Initialize(coinViewModel);
            _upgradeCoinView.Initialize(coinViewModel);
        }

    }
}
