using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb { 
public class HitFour : MonoBehaviour
{
    static public bool hit4;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (HitSix.hit6 == true && HitFive.hit5 == true && hit4 == true)
        {
                HUDControler.multiplier += 1;

                transform.position = startPos;
            hit4 = false;

            print("its working");
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Pinball")
        {
            HUDControler.score += 25 * HUDControler.multiplier;

            hit4 = true;
            transform.position = new Vector3(0, .5f, 0);
        }
    }
   }
 }
