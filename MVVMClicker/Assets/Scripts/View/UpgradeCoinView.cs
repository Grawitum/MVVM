using UnityEngine;
using UnityEngine.UI;
using MVVMClicker.ViewModel;

namespace MVVMClicker.View
{
    public class UpgradeCoinView : MonoBehaviour
    {
        [SerializeField] private Button _button;

        private ICoinViewModel _coinViewModel;

        public void Initialize(ICoinViewModel coinViewModel)
        {
            _coinViewModel = coinViewModel;
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => _coinViewModel.UpgradeCoin());
        }
    }
}
