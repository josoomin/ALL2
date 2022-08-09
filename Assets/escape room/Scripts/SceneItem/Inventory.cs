using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roomescape
{
    public class SceneIteminfo
    {
        public string _name;
        public int _count;

    }

    public class Inventory : MonoBehaviour
    {
        public static Inventory I; //ΩÃ±€≈Ê ¿ŒΩ∫≈œΩ∫

        //public List<SceneIteminfo> _itemList;
        [SerializeField] List<string> _itemList;

        void Awake()
        {
            I = this;   
        }

        public void AddItem(string itemName)
        {
            if(_itemList.Contains(itemName) == false)
            {
                _itemList.Add(itemName);
            }
        }
    }
}
