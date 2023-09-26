using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform exitPortal; // Drag the other portal here in the inspector
    public float cooldownTime = 1f; // Seconds before the player can teleport again
    private float nextTeleportTime;

    private void Start()
    {
        nextTeleportTime = Time.time;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Time.time > nextTeleportTime)
        {
            collision.transform.position = exitPortal.position; // Teleport the player to the exit portal
            nextTeleportTime = Time.time + cooldownTime;
            
            // Also set the cooldown on the exit portal to prevent immediate return
            exitPortal.GetComponent<Portal>().nextTeleportTime = Time.time + cooldownTime;
        }
    }
}

