using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bus : MonoBehaviour
{
    public float speed = 4.0f;
    private bool gameStart;

    // Start is called before the first frame update
    void Start()
    {
        gameStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartEnemies(gameStart);
    }
    
    private void StartEnemies(bool start)
    {
        if(start)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
    public void SetStartEnemies(bool start)
    {
        gameStart = start;
    }
}
