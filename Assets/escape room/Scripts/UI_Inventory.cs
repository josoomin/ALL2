using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roomescape
{
    // Inventory 객체의 아이템 리스트를 확인해서
    // 그대로 인벤토리 UI화면에 뿌려준다.

    public class UI_Inventory : MonoBehaviour
    {
        public List<UI_InvenItem> _itemList;

        public GameObject _itemTemplate;

        void Start()
        {
            _itemTemplate = transform.Find("UI_Inventory/Viewport/Content/Item(0)").gameObject;

            _itemTemplate.SetActive(false);

            UI_InvenItem[] array = GetComponentsInChildren<UI_InvenItem>();

            //List에 여러개(배열)를 집어넣을 때는 AddRange 함수 쓴다
            // (한 개를 집어넣을 때는 Add함수)
            _itemList.AddRange(array);

            //Inventory 객체의 _itemList를 확인해서, 그 갯수대로
            //UI_invenitem를 생성해준다.
            for(int i = 0; i < Inventory.I._itemList.Count; i++)
            {
                string itemName = Inventory.I._itemList[i];
                 
                Add(itemName);
            }
        }

        public void Add(string itemName)
        {
            GameObject cloneObj = Instantiate(_itemTemplate);
            cloneObj.transform.parent = _itemTemplate.transform.parent;
            cloneObj.SetActive(true);

            UI_InvenItem invenitem = cloneObj.GetComponent<UI_InvenItem>();
            invenitem.SetInfo(itemName);
        }

        void Update()
        {

        }
    }
}
