using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float moveSpeed = 3f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")* moveSpeed);
	}
}
