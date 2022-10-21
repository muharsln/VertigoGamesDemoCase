using UnityEngine;

namespace Vertigo.WheelState
{
    public class WheelStateManager : MonoBehaviour
    {
        public Transform SpinTransform;
        [SerializeField] public Transform NewObjectTargetPosition;
        [SerializeField] private Transform _newObjectParent;

        [SerializeField] private AbstractBaseWheelState currentState;
        public WheelSpinState WheelSpinState = new WheelSpinState();
        public WheelStopState WheelStopState = new WheelStopState();


        private void Start()
        {
            currentState = WheelStopState;
            currentState.StartState(this);
        }

        private void Update()
        {
            currentState.UpdateState(this);
        }

        public void SetGameState(AbstractBaseWheelState gameState)
        {
            currentState = gameState;
            gameState.StartState(this);
        }

        /// <summary>
        /// Game State change with WhellSpinState
        /// </summary>
        public void SetGameState()
        {
            currentState = WheelSpinState;
            currentState.StartState(this);
        }

        public GameObject CreateNewItem(GameObject gameObject)
        {
            return Instantiate(gameObject, _newObjectParent);
        }
    }
}