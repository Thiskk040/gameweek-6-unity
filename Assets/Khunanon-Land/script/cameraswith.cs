using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraswith : MonoBehaviour
{
    public GameObject FpsCamera;
    public GameObject CameraMain;
    bool activecamera = true;


    void Start()
    {
        CameraMain.SetActive(true);
        FpsCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            if(activecamera)
            {
                CameraMain.SetActive(false);
                FpsCamera.SetActive(true);
            }
            else
            {
                CameraMain.SetActive(true);
                FpsCamera.SetActive(false);
            }
            activecamera =! activecamera;
            
        }
    }
}
