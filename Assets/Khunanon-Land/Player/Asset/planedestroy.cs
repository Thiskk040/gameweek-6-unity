using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planedestroy : MonoBehaviour
{
    [SerializeField] public Transform player;
    [SerializeField] public Transform Respawnpoint;
   
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = Respawnpoint.transform.position;
    }
}
