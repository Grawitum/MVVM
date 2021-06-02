using MVVMClicker.ViewModel;
using UnityEngine.UI;
using UnityEngine;
using System;

namespace MVVMClicker.View
{
    internal sealed class CoinView : MonoBehaviour
    {
        [SerializeField] private Text _text;
        private ICoinViewModel _coinViewModel;

        public void Initialize(ICoinViewModel coinViewModel)
        {
            _coinViewModel = coinViewModel;
            _coinViewModel.OnCoinChange += OnCoinChange;
            OnCoinChange(_coinViewModel.CoinModel.CurrentCoin);
        }

        private void OnCoinChange(float currentCoin)
        {
            _text.text = ToKFormat(currentCoin);
        }

        private string ToKFormat(float number)
        {
            if ((number < 0) || (number >= Math.Pow(10, 15))) throw new ArgumentOutOfRangeException(nameof(number),
                "insert value betwheen 1 and 999999999999999");

            if (number < 1) return string.Empty;
            if (number >= Math.Pow(10, 12) && number < Math.Pow(10, 15)) return Math.Truncate((number / Math.Pow(10, 12))).ToString() + "T";
            if (number >= Math.Pow(10, 9) && number < Math.Pow(10, 12)) return Math.Truncate((number / Math.Pow(10, 9))).ToString() + "B";
            if (number >= Math.Pow(10, 6) && number < Math.Pow(10, 9)) return Math.Truncate((number / Math.Pow(10, 6))).ToString() + "M";
            if (number >= Math.Pow(10, 3) && number < Math.Pow(10, 6)) return Math.Truncate((number / Math.Pow(10, 3))).ToString() + "K";
            if (number < Math.Pow(10, 3)) return number.ToString();

            throw new ArgumentOutOfRangeException(nameof(number));
        }

        ~CoinView()
        {
            _coinViewModel.OnCoinChange -= OnCoinChange;
        }

    }
}
