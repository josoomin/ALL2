using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace roomescape
{
public class SceneObject : MonoBehaviour
{
        public RectTransform _infoTextTrans;
        public Vector3 _infoTextOffset;
        public string _infoText = "";

        void Start()
        {
            GameObject canvas = UiManager.I.gameObject;

            _infoTextTrans = canvas.transform.Find("infoText").GetComponent<RectTransform>();

            _infoTextTrans.gameObject.SetActive(false);
        }

        void Update()
        {
            // UpdateInfoTextPos();
        }

        private void OnMouseEnter()
        {
            Debug.Log(gameObject.name + "OnMouseEnter");

            _infoTextTrans.gameObject.SetActive(true);
            Text text = _infoTextTrans.GetComponent<Text>();
            text.text = _infoText;
        }

        private void OnMouseExit()
        {
            Debug.Log(gameObject.name + "OnMouseExit");

            _infoTextTrans.gameObject.SetActive(false);
        }

        //void UpdateInfoTextPos()
        //{
        //    // å���� ������ǥ
        //    Vector3 objPos = transform.position;

        //    // ������ǥ -> ��ũ�� ��ǥ
        //    Vector3 screenPos = UnityEngine.Camera.main.WorldToScreenPoint(objPos + _infoTextOffset);

        //    // UI Text(InfoText)�� ��ġ�� �� ��ũ�� ��ǥ�� �����
        //    _infoTextTrans.position = screenPos;
        //}
    }
}