using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public float boundary;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y < boundary)
        {
            die();
        }
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        string col = collider.gameObject.tag;
    
        if(col == "Projectile" || col == "Laser")
        {
            die();
        }
        
    }



    void die()
    {
        StartCoroutine(dieHelper());
    }


    IEnumerator dieHelper() 
    {
        respawn();
        anim.SetTrigger("die");
        yield return new WaitForSeconds(anim.GetCurrentAnimatorClipInfo(0).Length);
        anim.SetTrigger("idle");
    }

    public void respawn() {
        transform.position = new Vector3(0, 0, 0);
        GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);
    }
}
