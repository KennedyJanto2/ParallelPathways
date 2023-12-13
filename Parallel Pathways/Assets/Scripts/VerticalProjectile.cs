using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalProjectile : MonoBehaviour
{
    private float startingx;
    private float startingy;
    public float yboundary;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        startingx = transform.position.x;
        startingy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yboundary)
        {
            transform.position = new Vector3(startingx, startingy, -6);
        }
        transform.position -= transform.up * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.transform.position = new Vector3(0, 1, 0);
        }

    }
}
