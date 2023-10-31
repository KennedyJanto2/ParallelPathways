using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public GameObject originalProjectile;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject projectileClone = Instantiate(originalProjectile); //create one clone of projectile
        StartCoroutine(CreateProjectiles(30));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CreateProjectiles(int numbOfProjectiles)
    {
        for(int i = 0; i < numbOfProjectiles; i++)
        {
            GameObject projectileClone = Instantiate(originalProjectile, new Vector3(originalProjectile.transform.position.x, originalProjectile.transform.position.y + i+i, 0), originalProjectile.transform.rotation);
            yield return new WaitForSeconds(.35F);
        }
    }

  
}
