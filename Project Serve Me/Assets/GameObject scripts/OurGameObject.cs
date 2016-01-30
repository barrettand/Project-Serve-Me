using UnityEngine;
using System.Collections;

public abstract class OurGameObject : MonoBehaviour {

		public Transform trans; // includes location and scale
		public bool isBlocking;

	// Use this for initialization
	void Start () {
				trans = gameObject.transform;
				isBlocking = false;
	}
	
	// Update is called once per frame
	abstract void Update () {
	
	}
}
