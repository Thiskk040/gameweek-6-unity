using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinrotation : MonoBehaviour
   
{
   
    public int rotatespeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotatespeed, 0, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            Destroy(gameObject);
            
            
        }

    }
}
