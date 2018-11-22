using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    public float power, speed;
	
	void Start () {
        speed = 100f;
	}

    public void ShootBall(float magnitude)
    {
        speed %= magnitude;
        Debug.Log(speed);
    }
}
