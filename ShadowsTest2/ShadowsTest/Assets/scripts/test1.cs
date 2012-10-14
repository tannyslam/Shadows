using UnityEngine;
using System.Collections;

public class test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        Collider collider = collision.collider;
        Debug.Log("Reaching here");
        if (collider.CompareTag("testy"))
        {
            Debug.Log("Collided with true " + collider.tag);
        }
        else
        {
            Debug.Log("Collided with " + collider.tag);
        }
    }
}
