using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Spawner : MonoBehaviour {

	//float timePassed = 0.25f;
	//GameObject ammo;

	void Start()
	{
	
	}


	void Update()
	{
		Debug.DrawLine(transform.position, transform.position + transform.forward * 10.0f, Color.yellow);


		float speed = 5.0f;
		float width = 500;
		float height = 500;
		
		if ((transform.position.x < -(width / 2)) || (transform.position.x > width / 2) || (transform.position.z < -(height / 2)) || (transform.position.z > height / 2) || (transform.position.y < 0) || (transform.position.y > 100))
		{
			Destroy(gameObject);
		}
		transform.position += transform.forward * speed;
		Debug.DrawLine(transform.position, transform.position + transform.forward * 10.0f, Color.yellow);

		//timePassed += Time.deltaTime;


		//		if (timePassed > 0.25f) {
		
		//				GameObject ammo = new GameObject ();
		//				ammo.AddComponent<Lazer> ();
		//				ammo.transform.position = ammo.transform.position;
		//				ammo.transform.forward = ammo.transform.forward;
		//				timePassed = 0.0f;
		//		}

		}
}