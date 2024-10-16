 using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform playerTransform;

    private Vector3 offset;

    void Start()
    {
        // Find the player GameObject by its tag
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        // Calculate the initial offset between the player and the object
        offset = transform.position - playerTransform.position;
    }

    void Update()
    {
        // Get the player's current position
        Vector3 playerPosition = playerTransform.position;

        // Calculate the new position for the object
        // Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, playerPosition.z + offset.z);

        Vector3 newPosition = new Vector3(playerPosition.x + offset.x, transform.position.y, transform.position.z);

        // Update the object's position
        transform.position = newPosition;
    }
}
