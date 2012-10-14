using UnityEngine;
using System.Collections;

public class LightSource : MonoBehaviour {

    public static bool switchOn;
    public static float relativePosition;
    public float rotateSpeed;
    public GameObject shadowPlatform;
    Vector3 left;
    Vector3 right;
    Vector3 position;
    float offset;
	// Use this for initialization
	void Start () {
        switchOn = false;
        left = new Vector3(-0.1f, 0.0f, 0.0f);

        right = new Vector3(0.1f, 0.0f, 0.0f);

	}
	
		
	// Update is called once per frame
	void Update () {
        switchLight();
        moveLight();
        rotateLight();
        relativePosition = transform.position.x;
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            //Platform.shadowPlatformConstructed = true;
            //Directly above the platform
            Platform platform = other.gameObject.GetComponent<Platform>();
            if (!platform.shadowPlatformConstructed)
            {
                if (other.gameObject.transform.position.x == gameObject.transform.position.x)
                {
                    position = new Vector3(platform.transform.position.x, collider.gameObject.transform.position.y - 12, 0);
                    Debug.Log("1");
                }
                else if (other.gameObject.transform.position.x > gameObject.transform.position.x)
                {
                    offset = other.gameObject.transform.position.x - gameObject.transform.position.x;
                    position = new Vector3(platform.transform.position.x + offset, collider.gameObject.transform.position.y - 12, 0);
                    Debug.Log(offset);
                }
                else if (other.gameObject.transform.position.x < gameObject.transform.position.x)
                {
                    offset = gameObject.transform.position.x - other.gameObject.transform.position.x;
                    position = new Vector3(platform.transform.position.x - offset, collider.gameObject.transform.position.y - 12, 0);
                    Debug.Log(collider.gameObject.transform.position.x);
                }
                // position = new Vector3(collider.gameObject.transform.position.x - 10, collider.gameObject.transform.position.y - 10, 0);
                Instantiate(shadowPlatform, position, Quaternion.identity);
                platform.shadowPlatformConstructed = true;
            }
            }
            
    }

    void switchLight()
    {
        if (Input.GetKeyDown("e"))
        {
            switchOn = !switchOn;
        }
    }

    void rotateLight()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            gameObject.transform.RotateAround(Vector3.forward, 2 * Time.deltaTime);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            gameObject.transform.RotateAround(-Vector3.forward, 2 * Time.deltaTime);
        }
    }

    void moveLight()
    {
        if (switchOn)
        {
            if (Input.GetButton("Fire1"))
            {
               // transform.Translate(Vector3.left);
                transform.position = new Vector3(transform.position.x - 0.3f,transform.position.y,0);
            }
            if (Input.GetButton("Fire2"))
            {
                //transform.Translate(-Vector3.left);
                transform.position = new Vector3(transform.position.x + 0.3f, transform.position.y, 0);
            }

        }
		
    
    }
}
