using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winflag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "player")
        {
            Debug.Log("Kuy");
            SceneManager.LoadScene(1);
        }
    }
}
