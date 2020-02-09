using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
    public string msg;
    private float y;

	// Use this for initialization
	void Start () {
        y = transform.position.y;
	}
	
	void FixedUpdate () {
        transform.position = new Vector3(transform.position.x, y+ Mathf.Sin(Time.time * 5) * 0.1f, transform.position.z);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            GameController.Instance.say(msg);
            Destroy(this.gameObject);
        }
    }
}
