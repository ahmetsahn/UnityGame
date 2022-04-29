using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10;
    private float turnSpeed = 25.0f;
    private float horizantalInput;
    private float verticalInput;
    public GameObject mainCamera;
    public GameObject vehicleCamera;
    bool mainCamera1;
    

    void Start()
    {
        mainCamera1 = true;
        
    }

    
    void FixedUpdate()
    {
        horizantalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizantalInput);

        if(Input.GetKeyDown(KeyCode.F)) {
                changeCamera();
        }
    }

    public void changeCamera()
    {
        if (mainCamera1)
        {
            mainCamera.SetActive(false);
            vehicleCamera.SetActive(true);
            mainCamera1 = false;
        }

        else
        {
            vehicleCamera.SetActive(false);
            mainCamera.SetActive(true);
            mainCamera1 = true;
        }
    }



}



    


   
