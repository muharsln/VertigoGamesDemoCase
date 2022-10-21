using DG.Tweening;

namespace Vertigo.WheelState
{
    public class WheelStopState : AbstractBaseWheelState
    {
        public override void StartState(WheelStateManager stateManager)
        {
            SpinItem = stateManager.WheelSpinState.SpinItem;
        }

        public override void UpdateState(WheelStateManager stateManager)
        {
            if (SpinItem != null)
            {
                SpinItem.transform.DOMove(stateManager.NewObjectTargetPosition.position, 2f);
            }
        }
    }
}