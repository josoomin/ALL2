using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roomescape
{
    public class CameraRotator : MonoBehaviour
    {
        public CameraRotator _main;

        public float _angle = 90.0f;
        public float _rec = 45.0f;
        public float _move = 100.0f;

        public GameObject _ItemMenu;

        public GameObject _upB;
        public GameObject _downB;
        public GameObject _leftB;
        public GameObject _rightB;
        public GameObject _ItemB;

        void Start()
        {
            _upB.SetActive(false);
        }

        void Update()
        {

        }


        // > ������ ��ư ������, ī�޶� ����(y��) 90�� ����
        public void OnClickRightButton()
        {
            _main.transform.Rotate(new Vector3(0, _angle, 0));
        }

        // < ���� ��ư ������, ī�޶� ����(y��) 90�� ����
        public void OnClickLeftButton()
        {
            _main.transform.Rotate(new Vector3(0, -_angle, 0));
        }

        // �� ��ư ������ ī�޶� ���� (x��) 45 ����
        public void OnClickUpButton()
        {
            _main.transform.Rotate(new Vector3(-_rec, 0, 0));
            _upB.SetActive(false);
            _downB.SetActive(true);
            _leftB.SetActive(true);
            _rightB.SetActive(true);
        }

        // �Ʒ� ��ư ������ ī�޶� ���� (x��) 45 ����
        public void OnClickDownButton()
        {
            _main.transform.Rotate(new Vector3(_rec, 0, 0));
            _upB.SetActive(true);
            _downB.SetActive(false);
            _leftB.SetActive(false);
            _rightB.SetActive(false);
        }

        public void OnClickUpItemMenu()
        {
            if (_downB.activeSelf == true)
            {
                _downB.SetActive(false);
                _ItemMenu.transform.position = new Vector3(0, _move, 0);
            }

            else if (_downB.activeSelf == false)
            {
                _downB.SetActive(true);
                _ItemMenu.transform.position = new Vector3(0, -_move, 0);
            }

            
        }
    }
}