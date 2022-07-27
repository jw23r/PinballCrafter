using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb
{
    public class hit : MonoBehaviour
    {
        Vector3 startPos;
        static public bool hit1;
        // Start is called before the first frame update
        void Start()
        {
            startPos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (HitThree.hit3 == true && HitTwo.hit2 == true && hit1 == true)
            {
                HUDControler.multiplier += 1;
                transform.position = startPos;
                hit1 = false;
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == "Pinball")
            {
                HUDControler.score += 25 * HUDControler.multiplier;
                hit1 = true;
                transform.position = new Vector3(0, .5f, 0);
            }
        }
    }
}