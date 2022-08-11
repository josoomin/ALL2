using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roomescape
{
    public class UiManager : MonoBehaviour
    {
        public static UiManager I;

        GameObject _backBtnObj;
        GameObject _leftBtnObj;
        GameObject _rightBtnObj;

        public UI_Inventory _ui_iven;

        void Awake()
        {
            I = this;
        }

        void Start()
        {
            _backBtnObj = transform.Find("Back Button").gameObject;
            _leftBtnObj = transform.Find("Left Button").gameObject;
            _rightBtnObj = transform.Find("Right Button").gameObject;

            _ui_iven = transform.Find("UI_Inventory").GetComponent<UI_Inventory>();

            bool mainView = true;
            OnChangeView(mainView);
        }

        public void OnChangeView(bool isMainView) //true: 메인 뷰 상태, false: 확대된 상태
        {
            _backBtnObj.SetActive(!isMainView);
            _leftBtnObj.SetActive(isMainView);
            _rightBtnObj.SetActive(isMainView);
        }


        void Update()
        {

        }
    }
}
