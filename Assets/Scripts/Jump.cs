using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float jumpSpeed = 240f;
	public float forwardSpeed = 20f;

	private Rigidbody2D body2d;
	private InputState inputState;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<InputState> ();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (inputState.standing == true) {
			if (inputState.actionButton) {
				body2d.velocity = new Vector2 (transform.position.x < 0 ? forwardSpeed : 0, jumpSpeed);
			}
		}
	}
}
