using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (LightSource.switchOn)
        {
            gameObject.light.enabled = true;
        }
        else
        {
            gameObject.light.enabled = false;
        }
	}
}
