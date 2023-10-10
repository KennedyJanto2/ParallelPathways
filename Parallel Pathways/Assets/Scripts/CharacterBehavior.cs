using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehavior : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitPoints = 5;
    public HealthBarBehavior Healthbar;

    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitPoints;
        Healthbar.SetHealth(Hitpoints, MaxHitPoints);
    }

    // Update is called once per frame
    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        Healthbar.SetHealth(Hitpoints, MaxHitPoints);
        if(Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
