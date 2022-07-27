using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb
{
    public class HitThree : MonoBehaviour
    {
        static public bool hit3;
        Vector3 startPos;

        // Start is called before the first frame update
        void Start()
        {
            startPos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (hit.hit1 == true && HitTwo.hit2 == true && hit3 == true)
            {
                transform.position = startPos;
                hit3 = false;

                print("its working");
            }

        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == "Pinball")
            {
                HUDControler.score += 25 * HUDControler.multiplier;

                hit3 = true;
                transform.position = new Vector3(0, .5f, 0);
            }
        }
    }
}
