using UnityEngine;
using UnityEngine.UI;
using MVVMClicker.ViewModel;

namespace MVVMClicker.View
{
    internal sealed class GetCoinView : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private float _coin;

        private ICoinViewModel _coinViewModel;

        public void Initialize(ICoinViewModel coinViewModel)
        {
            _coinViewModel = coinViewModel;
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => _coinViewModel.GetCoin(_coin));
        }

    }
}
