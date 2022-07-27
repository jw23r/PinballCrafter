using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb { 
public class HitSix : MonoBehaviour
{
    static public bool hit6;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (HitFive.hit5 == true && HitFour.hit4 == true && hit6 == true)
        {
            transform.position = startPos;
            hit6 = false;

            print("its working");
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Pinball")
        {
            HUDControler.score += 25 * HUDControler.multiplier;

            hit6 = true;
            transform.position = new Vector3(0, .5f, 0);
        }
    }
}
}

