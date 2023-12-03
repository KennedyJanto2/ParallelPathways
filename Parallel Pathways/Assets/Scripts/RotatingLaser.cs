using UnityEngine;

public class RotatingLaser : MonoBehaviour
{
    private float degreeIterator;
    public float speed;
    public string direction;
    // Start is called before the first frame update
    void Start()
    {
        if(direction == "CounterClockwise") {
            degreeIterator = 1F;
            speed *= .01F;
        }
        else {
            degreeIterator = -1F;
            speed *= -.01F;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = Vector3.forward * degreeIterator;
        degreeIterator += speed;
        if(degreeIterator >= 360F || degreeIterator <= -360F) {
            degreeIterator = 1F;
        }
    }
}
