using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float startingx;
    private float startingy;
    public float boundary = 109;
    public float speed = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        startingx = transform.position.x;
        startingy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > boundary)
        {
            transform.position = new Vector3(startingx,startingy,0);
        }
        transform.position += transform.right * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.transform.position = new Vector3(0, 1, 0);
        }

    }
}