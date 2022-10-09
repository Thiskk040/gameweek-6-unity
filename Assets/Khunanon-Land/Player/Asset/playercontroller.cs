using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
    public Rigidbody rig;
    public float speed;
    public float jumpforce;
    bool isground;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;

        Vector3 vel = rig.velocity;
        vel.y = 0;
        rig.velocity = new Vector3(x, rig.velocity.y, z);
        transform.forward = rig.velocity;

        transform.forward = vel;

        if (Input.GetKeyDown(KeyCode.Space) && isground)
        {
            isground = false;
            rig.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
        /*
        if(transform.position.y < 5)
        {
            Gameover();
        }
        */

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal == Vector3.up)
        {
            isground = true;
        }
    }
    /*
    public void Gameover()
    {
        SceneManager.LoadScene(0);
    }
    */

}
   
