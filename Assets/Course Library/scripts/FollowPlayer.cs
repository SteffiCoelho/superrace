using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    //capture player
    public GameObject player;
    public int setCamera;
    private Vector3 offset;
    private Vector3 offset1 = new Vector3(0, 5, -6);
    private Vector3 offset2 = new Vector3(0, 1.7f, 1);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (setCamera == 1)
        {
            offset = offset1;
        }
        if (setCamera == 2) 
        {
            offset = offset2;
        }

        //follow player
        transform.position = player.transform.position + offset;
    }       
}
