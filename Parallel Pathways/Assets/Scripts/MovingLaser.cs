using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLaser : MonoBehaviour
{
    public int start;
    public Transform[] points;
    public float speed;
    private int i;
    private Vector3 originalScale;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[start].position;
        originalScale = new Vector3(1,1,1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, points[i].position) < .02f)
        {
            i++;
            if(i == points.Length)
            {
                i = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
}
