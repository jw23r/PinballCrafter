using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb { 
public class HitNine : MonoBehaviour
{
    static public bool hit9;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (HitEight.hit8 == true && HitSeven.hit7 == true && hit9 == true)
        {
            transform.position = startPos;
            hit9 = false;

            print("its working");
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Pinball")
        {
            HUDControler.score += 25 * HUDControler.multiplier;

            hit9 = true;
            transform.position = new Vector3(0, .5f, 0);
        }
    }
}
}
