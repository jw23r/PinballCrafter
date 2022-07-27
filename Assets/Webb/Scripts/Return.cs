using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace webb
{
    public class Return : MonoBehaviour
    {
        public static Vector3 startPos;
        public int time = 0;
        // Start is called before the first frame update
        void Start()
        {
            startPos = gameObject.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            time += 1;

        }
        void OnTriggerEnter(Collider collider)
        {

            if (collider.transform.tag == "Return")
            {
                
                if (HUDControler.lives > 0 )
                {
                    gameObject.transform.position = startPos;
                  
                        HUDControler.lives -= 1;
                        time = 0;
                    
                    }

            }
        }
    }
}