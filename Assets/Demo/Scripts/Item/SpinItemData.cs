using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vertigo.Item
{
    [CreateAssetMenu(menuName = "Vertigo/Spin/Item Data")]
    public class SpinItemData : ScriptableObject
    {
        public string ItemID;

        [SerializeField] private GameObject _item;

        public GameObject InstantiatePrefabs(Transform parent)
        {
            return Instantiate(_item, parent);
        }
    }
}