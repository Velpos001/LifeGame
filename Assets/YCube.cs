using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class YCube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Log when any object collides with the cube.
        Debug.Log("Hit");
        // If the object has the "Player" tag, destroy the game object.
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            // Each time the player hits, it will log "Break".
            Debug.Log("Break");
        }
    }
}
