using System.Collections.Generic;
using UnityEngine;

namespace Vertigo.Item
{
    public class SpinItemController : MonoSingleton<SpinItemController>
    {
        [SerializeField] private SpinItemData[] _spinItemDataArray;
        [SerializeField] private Transform[] _itemParents;

        [HideInInspector] public List<GameObject> SpinItems;

        private void Start()
        {
            for (int i = 0; i < _spinItemDataArray.Length; i++)
            {
                var instantiated = _spinItemDataArray[i].InstantiatePrefabs(_itemParents[i]);
                SpinItems.Add(instantiated);
            }
        }
    }
}