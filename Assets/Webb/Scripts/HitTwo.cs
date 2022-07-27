using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb
{
    public class HitTwo : MonoBehaviour
    {
        public static bool hit2;
        Vector3 startPos;

        // Start is called before the first frame update
        void Start()
        {
            startPos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (hit.hit1 == true && hit2 == true && hit2 == true)
            {
                transform.position = startPos;
                hit2 = false;

            }

        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == "Pinball")
            {
                HUDControler.score += 25 * HUDControler.multiplier;

                hit2 = true;
                transform.position = new Vector3(0, .5f, 0);
            }
        }

    }
}