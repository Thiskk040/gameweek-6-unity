using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public float movespeed;

    public float minXrot;
    public float maxXrot;

    private float curXrot;

    public float minZzoom;
    public float maxZzoom;

    public float zoomSpeed;
    public float rotateSpeed;

    private float curZoom;

    private Camera cam;


    private void Start()
    {
        cam = Camera.main;
        curZoom = cam.transform.localPosition.y;
        curXrot = -50;
    }
    void Update()
    {
        curZoom += Input.GetAxis("Mouse ScrollWheel") * -zoomSpeed;
        curZoom = Mathf.Clamp(curZoom, minZzoom, maxZzoom);
        cam.transform.localPosition = Vector3.up * curZoom;

        // camera look
        if (Input.GetMouseButton(1))
        {
            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");
            curXrot += -y * rotateSpeed;
            curXrot = Mathf.Clamp(curXrot, minXrot, maxXrot);

            transform.eulerAngles = new Vector3(curXrot, transform.eulerAngles.y + (x * rotateSpeed), 0.0f);
        }

        // movement
        Vector3 forward = cam.transform.forward;
        forward.y = 0.0f;
        forward.Normalize();
        Vector3 right = cam.transform.right;
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        Vector3 dir = forward * moveZ + right * moveX;
        dir.Normalize();
        dir *= movespeed * Time.deltaTime;
        transform.position += dir;



    }
}
