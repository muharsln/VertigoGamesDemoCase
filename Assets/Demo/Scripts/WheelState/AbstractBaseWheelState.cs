using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vertigo.WheelState
{
    public abstract class AbstractBaseWheelState
    {
        public GameObject SpinItem;
        public abstract void StartState(WheelStateManager stateManager);

        public abstract void UpdateState(WheelStateManager stateManager);
    }
}