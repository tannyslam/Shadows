using UnityEngine;
using System.Collections;

public class ShadowManager : MonoBehaviour {
    public GameObject shadowPlatform;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionEnter(Collision collision)
    {
        Collider collider = collision.collider;
        if (collider.CompareTag("Platform"))
        {
            Asteroid roid = collider.gameObject.GetComponent<Asteroid>();
            roid.Die();
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Collided with " + collider.tag);
        }
    }
}
