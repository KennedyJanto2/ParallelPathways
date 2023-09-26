using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject portalAPrefab;
    public GameObject portalBPrefab;

    private GameObject currentPortalA;
    private GameObject currentPortalB;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Assumes "Fire1" is mapped to the left mouse button or equivalent
        {
            ShootPortal(ref currentPortalA, portalAPrefab, currentPortalB);
        }
        else if (Input.GetButtonDown("Fire2")) // Assumes "Fire2" is mapped to the right mouse button or equivalent
        {
            ShootPortal(ref currentPortalB, portalBPrefab, currentPortalA);
        }
    }

    void ShootPortal(ref GameObject currentPortal, GameObject portalPrefab, GameObject otherPortal)
    {
        // Destroy the existing portal if there is one
        if (currentPortal != null)
        {
            Destroy(currentPortal);
        }

        // Calculate the world position of the cursor
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Ensure that the z-coordinate of the mousePosition is set correctly (usually to 0 in 2D games)
        mousePosition = new Vector2(mousePosition.x, mousePosition.y);

        // Instantiate a new portal at the cursor's position
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
