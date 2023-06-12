using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    //vruuuuum
    private float speed = 20f;
    private float turnSpeed = 20.0f;

    //eixos
    private float horizontalInput;
    private float verticalInput;

    //take camera

    public GameObject camera1;
    public GameObject camera2;


    private Camera cameraMain;
    private Camera cameraPilot;

    private bool gameStart;
    private bool colliderFinal;

    void Start()
    {
        cameraMain = camera1.GetComponent<Camera>();
        cameraPilot = camera2.GetComponent<Camera>();
        gameStart = false;
        colliderFinal = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameStart)
        {

            //capture input Z
            verticalInput = Input.GetAxis("Vertical1");

            //capture input Y
            horizontalInput = Input.GetAxis("Horizontal1");

            //move car
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

            //move car to make a turn

            if (verticalInput != 0)
            {
                transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                cameraMain.enabled = !cameraMain.enabled;
                cameraPilot.enabled = !cameraPilot.enabled;
            }
        }
    }
    public void SetStartPlayer(bool start)
    {
        gameStart = start;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Final")
        {
            colliderFinal = true;
        }

    }

    public bool detectFinal()
    {
        return colliderFinal;
    }
}

