using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject Bot = new GameObject ();
		Bot.AddComponent<MeshRenderer> ();
		Bot.AddComponent<MeshFilter> ();
		Bot.AddComponent<StateMachine>();
		Bot.AddComponent<SteeringBehaviours>();
		Debug.DrawLine(transform.position, transform.position + transform.forward * 10.0f, Color.red);
	
        GameObject leader = GameObject.FindGameObjectWithTag("leader");
        GameObject teaser = GameObject.FindGameObjectWithTag("teaser");
		GameObject teaser2 = GameObject.FindGameObjectWithTag("teaser2");
		GameObject teaser3 = GameObject.FindGameObjectWithTag("teaser3");
		GameObject ammo = GameObject.FindGameObjectWithTag("pickup");


        leader.GetComponent<StateMachine>().SwitchState(new IdleState(leader, teaser));
        teaser.GetComponent<StateMachine>().SwitchState(new TeaseState(teaser, leader));
		teaser2.GetComponent<StateMachine>().SwitchState(new TeaseState(teaser2, leader));
		teaser3.GetComponent<StateMachine>().SwitchState(new TeaseState(teaser3, leader));
		//ammo.GetComponent<StateMachine> ().SwitchState (new IdleState (ammo, leader));


        leader.renderer.material.color = Color.red;
        teaser.renderer.material.color = Color.blue;
		teaser2.renderer.material.color = Color.blue;
		teaser3.renderer.material.color = Color.blue;
		Bot.renderer.material.color = Color.blue;
		ammo.renderer.material.color = Color.yellow;



        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
