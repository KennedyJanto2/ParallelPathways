using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public float boundary;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < boundary)
        {
            respawn();
        }
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        string col = collider.gameObject.tag;
    
        if(col == "Laser")
        {
            respawn();
        }
        
    }

    public void respawn() {
        transform.position = new Vector3(0, 0, 0);
        //insert die animation here
        GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);
    }
}
