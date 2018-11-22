using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
    public GameObject cannon, pin;
    private bool cannonfired, turnangle, powerbar;
    private float angle, maxAngle, minAngle, speed;
   
    


	void Start () {
        cannonfired = false;
        angle = 0f;
        speed = 100.0f;
        maxAngle = 75f;
        minAngle = 0f;
        turnangle = false;
        powerbar = false;
	}

    void Update()
    {

      
        if (!turnangle && !powerbar)
        {
               angle += (speed * Time.deltaTime);
            if (angle >= maxAngle)
            {
                Turnangle();
            }
            
        }
        else if (turnangle && !powerbar)
        {
            angle -= (speed * Time.deltaTime);
            
            if (angle <= minAngle)
            {
                Turnangle();
            }
        }


        cannon.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
       
        if (!powerbar && Input.GetMouseButtonDown(0))
        {
            powerbar = !powerbar;
            pin.GetComponent<Pin>().Rotatepin();
        }

    }
    void Turnangle()
    {
        
        turnangle = !turnangle;
    }
	}

