using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallRespawn : MonoBehaviour
{
    public float boundary;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.y < boundary)
        {
            transform.position = new Vector3(0, 1, 0);
        }
    }
}
