using UnityEngine;
using System.Collections;

public class PickUpKey : MonoBehaviour {
	public Door doorToUnlock;
	private float y;

	void Start () {
        y = transform.position.y;
	}
	
	void FixedUpdate () {
        transform.position = new Vector3(transform.position.x, y+ Mathf.Sin(Time.time * 5) * 0.1f, transform.position.z);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            GameController.Instance.inventory.Add("KEY", 1);
            GameController.Instance.say("A key.\nI wonder what this opens.");
            GameController.Instance.updateObj(1);
            doorToUnlock.isOpen = true;
            Destroy(this.gameObject);
			
        }
    }
}
