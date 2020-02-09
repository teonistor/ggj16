using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
    public Vector2 newCamPoz;

    public string lockedMessage;
    public bool exitUp;
    public bool exitDown;
    public bool exitLeft;
    public bool exitRight;
    public GameObject exit;
    public bool goesOutside;
    public bool isOpen;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {
        if (isOpen)
        {
            //other.transform.position = newPoz;
            other.transform.position = exit.transform.position + getOffset();
            GameController.Instance.camera.transform.position = new Vector3(newCamPoz.x, newCamPoz.y, -10f);
            GameController.Instance.outside = goesOutside;
        }
        else
            GameController.Instance.say(lockedMessage);
    }

    Vector3 getOffset()
    {
        if (exitUp)
        {
            return new Vector3(0f, 2f, 0f);
        }
        if (exitDown)
        {
            return new Vector3(0f, -2f, 0f);
        }
        if (exitLeft)
        {
            return new Vector3(-2f, 0f, 0f);
        }
        if (exitRight)
        {
            return new Vector3(+3f, 0f, 0f);
        }
        else return new Vector3(0f, 0f, 0f);
    }
}
