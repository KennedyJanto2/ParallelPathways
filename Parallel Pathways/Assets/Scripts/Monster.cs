using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    //private GameObject pointA;
    //private GameObject pointB;
    private Rigidbody2D rb;

    public DetectionZone attackZone;
    public bool _hasTarget = false;         // custom setter for hastarget
    private Animator animator;

    // property of hastarget
    public bool HasTarget {
        get { return _hasTarget; }
        private set
        {
            _hasTarget = value;
            animator.SetBool(AnimationStrings.hasTarget, value);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HasTarget = attackZone.detectedColliders.Count > 0;
    }
}
