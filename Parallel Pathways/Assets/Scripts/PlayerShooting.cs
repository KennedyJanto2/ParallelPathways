using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class PlayerShooting : MonoBehaviour
{
    public GameObject portalAPrefab;
    public GameObject portalBPrefab;

    private GameObject currentPortalA;
    private GameObject currentPortalB;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Assumes "Fire1" is mapped to the left mouse button or equivalent
        {
            ShootPortal(ref currentPortalA, portalAPrefab, currentPortalB);
            anim.SetTrigger("attack");
        }
        else if (Input.GetButtonDown("Fire2")) // Assumes "Fire2" is mapped to the right mouse button or equivalent
        {
            ShootPortal(ref currentPortalB, portalBPrefab, currentPortalA);
            anim.SetTrigger("attack");
        }
    }

    void ShootPortal(ref GameObject currentPortal, GameObject portalPrefab, GameObject otherPortal)
    {
        // Calculate the world position of the cursor
        Vector3 mousePosInScreen = Input.mousePosition;
        mousePosInScreen.z = Mathf.Abs(Camera.main.transform.position.z);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(mousePosInScreen);

        // Perform a Raycast to check for tilemap surfaces
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        if (hit.collider != null)
        {
            // Check if the hit object is part of the tilemap
            if (hit.collider.GetComponent<TilemapRenderer>() != null)
            {
                // The raycast hit a tilemap, prevent portal creation
                return;
            }
        }
        
        // If no tilemap is hit, destroy the existing portal and instantiate a new one at the mouse position
        if (currentPortal != null)
        {
            Destroy(currentPortal);
        }
        currentPortal = Instantiate(portalPrefab, mousePosition, Quaternion.identity);

        // Update the exit portal for both the new and existing portal
        if (otherPortal != null)
        {
            Portal portalScript = currentPortal.GetComponent<Portal>();
            Portal otherPortalScript = otherPortal.GetComponent<Portal>();

            if (portalScript != null && otherPortalScript != null)
            {
                portalScript.exitPortal = otherPortal.transform;
                otherPortalScript.exitPortal = currentPortal.transform;
            }
        }
    }

}
