using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class TouchClimibing : MonoBehaviour
{
    // Public variable to set the upward distance in the Inspector
    public float upwardDistance = 1.0f;
    public GameObject playerPosition;
    public Collider LeftHandCollider;
    public Collider RightHandCollider;
    public bool OnlyRightHand = false;
    public bool OnlyLeftHand = false;
    public float moveDuration = 1.0f; // Duration for the smooth movement
    private Collider ThisObjectColider;
    [SerializeField] BNG.PlayerClimbing playerclimbeSuppport;
    
    

    private void Start()
    {
        ThisObjectColider = GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other == RightHandCollider && OnlyRightHand)
        {
            playerclimbeSuppport.onGrabbedClimbable();
           // StartCoroutine(MoveUpSmoothly(Vector3.up * upwardDistance));
          //  ThisObjectColider.enabled = false;
          
        }
        if (other == LeftHandCollider && OnlyLeftHand)
        {
            playerclimbeSuppport.onGrabbedClimbable();
           //   StartCoroutine(MoveUpSmoothly(Vector3.up * upwardDistance));
           //   ThisObjectColider.enabled = false;
        }
    }

    private IEnumerator MoveUpSmoothly(Vector3 offset)
    {
        Vector3 startPos = playerPosition.transform.position;
        Vector3 endPos = startPos + offset;
        float elapsedTime = 0f;

        while (elapsedTime < moveDuration)
        {
            playerPosition.transform.position = Vector3.Lerp(startPos, endPos, elapsedTime / moveDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        playerPosition.transform.position = endPos;
    }
}
