using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public float xpos;
    public float ypos;
    public int numbOfProjectiles;
    public GameObject originalProjectile;
    public string pattern;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject projectileClone = Instantiate(originalProjectile); //create one clone of projectile
        originalProjectile.transform.position = new Vector3(xpos,ypos,0);
        StartCoroutine(CreateProjectiles(numbOfProjectiles, pattern));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CreateProjectiles(int NumbOfProjectiles, string typePattern)
    {
        if(typePattern == "RightIncrease")
        {
            for (int i = 0; i < NumbOfProjectiles; i++)
            {
                GameObject projectileClone = Instantiate(originalProjectile, new Vector3(originalProjectile.transform.position.x, originalProjectile.transform.position.y + i + i, 0), originalProjectile.transform.rotation);
                yield return new WaitForSeconds(.35F);
            }
        }
        else if(typePattern == "RightDecrease")
        {
            for (int i = 0; i < NumbOfProjectiles; i++)
            {
                GameObject projectileClone = Instantiate(originalProjectile, new Vector3(originalProjectile.transform.position.x, originalProjectile.transform.position.y - i - i, 0), originalProjectile.transform.rotation);
                yield return new WaitForSeconds(.35F);
            }
        }
        else if(typePattern == "DownScattered")
        {
            for (int i = 0; i < NumbOfProjectiles; i++)
            {
                GameObject projectileClone = Instantiate(originalProjectile, new Vector3(originalProjectile.transform.position.x + i + i, originalProjectile.transform.position.y, 0), originalProjectile.transform.rotation);
                yield return new WaitForSeconds(.35F);
            }
        }
    }

  
}
