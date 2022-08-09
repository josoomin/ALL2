using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace roomescape
{
    public class SceneItem : MonoBehaviour
    {
        public RectTransform _itemTextTrans;
        public string _itemText = "";

        void Start()
        {
            GameObject canvas = UiManager.I.gameObject;

            _itemTextTrans = canvas.transform.Find("ItemText").GetComponent<RectTransform>();
            _itemTextTrans.gameObject.SetActive(false);
        }

        void Update()
        {
            
        }

        private void OnMouseEnter()
        {
            _itemTextTrans.gameObject.SetActive(true);
            Text text = _itemTextTrans.GetComponent<Text>();
            text.text = _itemText;
        }

        private void OnMouseExit()
        {
            _itemTextTrans.gameObject.SetActive(false);
        }

        void OnMouseDown()
        {
            //인벤토리에 접근해서, 데이터(아이템)를 넣어주기
            Inventory.I.AddItem(_itemText);

            gameObject.SetActive(false);

            _itemTextTrans.gameObject.SetActive(false);
        }
    }
}
