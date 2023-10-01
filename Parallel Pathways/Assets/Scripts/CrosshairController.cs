using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairController : MonoBehaviour
{
    public Camera mainCamera;
    public Sprite availableSprite;  // Assign the circle sprite in the inspector
    public Sprite notAvailableSprite;  // Assign the X sprite in the inspector

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Cursor.visible = false;  // Hide the default cursor
    }

    void Update()
    {
        // Move the crosshair to the mouse position
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Mathf.Abs(mainCamera.transform.position.z);
        transform.position = mainCamera.ScreenToWorldPoint(mousePosition);

        // Perform a Raycast to check for objects with the "Platform" tag
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero);
        if (hit.collider != null && hit.collider.CompareTag("Platform"))
        {
            // Change the crosshair to the not available sprite (X)
            spriteRenderer.sprite = notAvailableSprite;
        }
        else
        {
            // Change the crosshair to the available sprite (Circle)
            spriteRenderer.sprite = availableSprite;
        }
    }
}
