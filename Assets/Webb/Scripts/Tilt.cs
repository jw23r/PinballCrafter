﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb
{
    public class Tilt : MonoBehaviour
    {
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            TiltTable();
        }

        private void TiltTable()
        {
            if (Input.GetButtonDown("Tilt"))
            {
                transform.Rotate(0, 0, 2, Space.Self);

            }
            if (Input.GetButtonUp("Tilt"))
            {
                transform.Rotate(0, 0, -2, Space.Self);

            }
            if (Input.GetButtonDown("Tilt"))
            {
                transform.Rotate(2, 0, 0, Space.Self);

            }
            if (Input.GetButtonUp("Tilt"))
            {
                transform.Rotate(-2, 0, 0, Space.Self);

            }
        }
    }
}