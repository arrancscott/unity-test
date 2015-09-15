using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public float velocity = 10;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y - Time.deltaTime, gameObject.transform.position.z);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Ship"){
			//Application.LoadLevel(Application.loadedLevel);

		}
		Debug.Log("Hit the floor");
	}
}
