using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotVehicle : MonoBehaviour
{

    private float speed = 10;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);    
    }
}