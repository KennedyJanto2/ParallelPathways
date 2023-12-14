using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class DirectionalProjectile : MonoBehaviour
{
    private float startingx;
    private float startingy;
    public Transform target;
    public float radiusBoundary;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        startingx = transform.position.x;
        startingy = transform.position.y;
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 startpos = new Vector3(startingx, startingy, transform.position.z);

        //if target is outside of boundary then respawn projectile
        if(Vector3.Distance(target.position, startpos) > radiusBoundary)
        {
            transform.position = startpos;
        }

        //get direction of target and move towards that direction
        Vector3 direction = (target.position - transform.position).normalized;
        //transform.Translate(direction * Time.deltaTime * speed);
        transform.Translate(speed/100,0,0);

        //rotate to look at target
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
    
        if(collider.gameObject.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<Die>().respawn();
        }
        
    }
}
