using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDie : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            collider.gameObject.transform.position = new Vector3(0, 1, 0);
        }
        
    }
}
