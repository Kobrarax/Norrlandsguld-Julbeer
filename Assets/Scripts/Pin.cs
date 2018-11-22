using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {
    private float maxAngle, minAngle, angle, speed, ballSpeed;
    private bool rotate, changAngle;
  

	void Start () {
        rotate = false;
        speed = 200f;
        maxAngle = 90f;
        minAngle = -90f;
        angle = 0f;
        ballSpeed = 100f;
	}
	
	void Update () {
        if (rotate && !changAngle)
        {
            angle += (speed * Time.deltaTime);
            if (angle >= maxAngle)
            {
                Turnangle();
            }

        }
        else if (changAngle && rotate)
        {
            angle -= (speed * Time.deltaTime);

            if (angle <= minAngle)
            {
                Turnangle();
            }
        }
        if (rotate && Input.GetMouseButtonDown(0))
        {
           // rotate = !rotate;
            Shoot();
        }

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
    public void Rotatepin()
    {
        rotate = true;
    }
    void Turnangle()
    {
        changAngle = !changAngle;
    }
    void Shoot()
    {
        // räkna ut % hastigheten
        angle %= speed;
        Debug.Log(speed);
    }
}
