using UnityEngine;
using System.Collections;

public class LightSource : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	Vector3 left = new Vector3(-0.1f, 0.0f, 0.0f);
	
	Vector3 right = new Vector3(0.1f, 0.0f, 0.0f);
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButton("Fire1"))
		{
			transform.Translate(left);
		}
				if (Input.GetButton("Fire2"))
		{
			transform.Translate(right);
		}
		
		
	}
}
