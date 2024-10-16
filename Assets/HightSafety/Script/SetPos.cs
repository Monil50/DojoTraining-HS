using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPos : MonoBehaviour
{
    public GameObject obj;
    public Transform target;
    public Vector3 DesirePos;


    public void SetPosition()
    {
        obj.transform.position = DesirePos;
    }

    public void SetPositionToTarget()
    {
        obj.transform.position = target.position;
    }
}
