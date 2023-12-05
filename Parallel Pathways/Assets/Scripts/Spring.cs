using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public string pattern;
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
            if(pattern == "RightAngled" ) {
                collider.GetComponent<Rigidbody2D>().velocity = new Vector3(100,100,0);
            }else {
                float x = collider.GetComponent<Rigidbody2D>().velocity.x;
                collider.GetComponent<Rigidbody2D>().velocity = new Vector3(x,100,0);
            }
        }
    }
}
