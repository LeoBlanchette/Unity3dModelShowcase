using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LB3D
{
    public class Turntable : MonoBehaviour
    {
        public float rotateSpeed = 5;

        private bool doRotate = false;
        void Start()
        {

        }

        void Update()
        {
            CheckInput();
            RotateTurntable();
        }

        public void RotateTurntable()
        {
            if (!doRotate) return;
            transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }

        public void CheckInput()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                doRotate = !doRotate;
            }
        }
    }
}