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

        void Awake()
        {
            I = this;
        }

        void Start()
        {
            _backBtnObj = transform.Find("Back Button").gameObject;
            _leftBtnObj = transform.Find("Left Button").gameObject;
            _rightBtnObj = transform.Find("Right Button").gameObject;
            

            bool mainView = true;
            OnChangeView(mainView);
        }

        public void OnChangeView(bool isMainView) //true: ���� �� ����, false: Ȯ��� ����
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
