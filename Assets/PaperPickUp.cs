using UnityEngine;
using System.Collections;

public class PaperPickUp : MonoBehaviour {
    public Door roomDoor; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        GameController.Instance.updateObj(0);
        roomDoor.isOpen = true;
        GameController.Instance.say("Seems like I have to do something in the locked church");
        Destroy(this.gameObject);
    }
}
