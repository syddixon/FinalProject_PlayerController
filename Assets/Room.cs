using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;

    public Vector2 minBounds; // bottom-left corner of the room
    public Vector2 maxBounds; // top-right corner of the room

    void Update()
    {
        if (player == null) return;

        // Move toward player
        Vector3 direction = (player.position - transform.position).normalized;
        direction.y = 0f;
        transform.position += direction * speed * Time.deltaTime;

        // Clamp to room bounds
        float clampedX = Mathf.Clamp(transform.position.x, minBounds.x, maxBounds.x);
        float clampedZ = Mathf.Clamp(transform.position.z, minBounds.y, maxBounds.y);
        transform.position = new Vector3(clampedX, transform.position.y, clampedZ);
    }
}
