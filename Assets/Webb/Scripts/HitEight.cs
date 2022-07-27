using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb { 
public class HitEight : MonoBehaviour
{
    static public bool hit8;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (HitNine.hit9 == true && HitSeven.hit7 == true && hit8 == true)
        {
                HUDControler.multiplier += 1;

                transform.position = startPos;
            hit8 = false;

            print("its working");
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Pinball")
        {
            HUDControler.score += 25 * HUDControler.multiplier;

            hit8 = true;
            transform.position = new Vector3(0, .5f, 0);
        }
    }
}
}