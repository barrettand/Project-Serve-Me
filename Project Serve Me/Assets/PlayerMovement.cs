using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			rigidbody2D.transform.Translate(new Vector2(0, .1f));
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			rigidbody2D.transform.Translate(new Vector2(0, -0.1f));
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			rigidbody2D.transform.Translate(new Vector2(0.1f, 0));
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			rigidbody2D.transform.Translate(new Vector2(-0.1f, 0));
		}
	
	}
}
