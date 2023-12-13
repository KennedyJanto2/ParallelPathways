using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public float speed = 1.5F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Player") {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity *= speed;
        }
    }
}
