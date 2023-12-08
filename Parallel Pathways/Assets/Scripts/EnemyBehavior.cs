using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public float Hitpoints;
    public float MaxHitPoints = 5;


    void Start()
    {
        Hitpoints = MaxHitPoints;
    }

    // Update is called once per frame
    void TakeHit(float damage)
    {
        Hitpoints -= damage;
        if(Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
