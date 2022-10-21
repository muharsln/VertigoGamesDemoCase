using DG.Tweening;
using UnityEngine;
using Vertigo.Item;

namespace Vertigo.WheelState
{
    public class WheelSpinState : AbstractBaseWheelState
    {
        private int _randomItem;
        private float _itemAngles;
        public override void StartState(WheelStateManager stateManager)
        {
            SpinItem = null;
            _randomItem = Random.Range(0, SpinItemController.Instance.SpinItems.Count);
            _itemAngles = 360 / SpinItemController.Instance.SpinItems.Count;
        }

        public override void UpdateState(WheelStateManager stateManager)
        {
            stateManager.SpinTransform.DORotate(Vector3.forward * (_randomItem * _itemAngles), 2f, RotateMode.FastBeyond360).SetEase(Ease.OutBack).OnComplete(() =>
            {
                stateManager.SetGameState(stateManager.WheelStopState);
                if (SpinItem == null)
                {
                    SpinItem = stateManager.CreateNewItem(SpinItemController.Instance.SpinItems[_randomItem]);
                    SpinItem.transform.localScale = Vector3.one * 1.5f;
                }
            });
        }
    }
}