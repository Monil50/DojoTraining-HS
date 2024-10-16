using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;
    

public class Gravity : MonoBehaviour
{
    public PlayerGravity pg;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void gravityLow()
    {
        pg.Gravity = new Vector3(0, -1, 0);
        StartCoroutine(delayblack());
    }

    IEnumerator delayblack()
    {
        yield return new WaitForSeconds(3);
        cube.SetActive(true);
    }
}
