using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb { 
public class HitSeven : MonoBehaviour
    {
        static public bool hit7;
Vector3 startPos;

// Start is called before the first frame update
void Start()
{
    startPos = transform.position;
}

// Update is called once per frame
void Update()
{
    if (HitNine.hit9 == true && HitEight.hit8 == true && hit7 == true)
    {
        transform.position = startPos;
        hit7 = false;

        print("its working");
    }

}
private void OnCollisionEnter(Collision collision)
{
    if (collision.transform.tag == "Pinball")
    {
        HUDControler.score += 25 * HUDControler.multiplier;

        hit7 = true;
        transform.position = new Vector3(0, .5f, 0);
    }
}
}
}
