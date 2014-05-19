using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class Lazer:MonoBehaviour
{
	public float currentAmmo = 10f;

    public void Update()
    {
        float speed = 5.0f;
        float width = 500;
        float height = 500;


        if ((transform.position.x < -(width / 2)) || (transform.position.x > width / 2) || (transform.position.z < -(height / 2)) || (transform.position.z > height / 2) || (transform.position.y < 0) || (transform.position.y > 100))
        {
            Destroy(gameObject);
			float currentAmmo =  -1f;
        }
        transform.position += transform.forward * speed;
        Debug.DrawLine(transform.position, transform.position + transform.forward * 10.0f, Color.red);
    }
}
