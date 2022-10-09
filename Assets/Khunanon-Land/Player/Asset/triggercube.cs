using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class triggercube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player");
            //other.GetComponent<playercontroller>().Gameover();
        }
    }
}
