using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AtmosphericScatteringONeils
{
    public class RotateEarth : MonoBehaviour
    {

        public float speed = 1.0f;

        void Update()
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * speed, 0));
        }
    }
}
