using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb { 
public class HitFive : MonoBehaviour
{
    static public bool hit5;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (HitSix.hit6 == true && HitFour.hit4 == true &&  hit5 == true)
        {
            transform.position = startPos;
            hit5 = false;

            print("its working");
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Pinball")
        {
            HUDControler.score += 25 * HUDControler.multiplier;

            hit5 = true;
            transform.position = new Vector3(0, .5f, 0);
        }
    }
}
}
