using UnityEngine;
using System.Collections;

public class NPCs : MonoBehaviour {
    public bool questGiven;
    public Door abandonedHouse;
    public Door wayBack;
    public GameObject darkMessage;
    public GameObject darkMessage2;
    public GameObject pgram;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (!questGiven){
            GameController.Instance.sayPriest("HELLO THERE\n TO CLEAN YOUR SOUL YOU MUST GO TO THE ABANDONED HOUSE");
            GameController.Instance.light.enabled = false;
            GameController.Instance.updateObj(2);
            abandonedHouse.isOpen = true;
            wayBack.isOpen = false;
            wayBack.lockedMessage = "I should go to the abandoned house north of the cemetary";
            darkMessage.GetComponent<BoxCollider>().enabled = true;
            darkMessage2.GetComponent<BoxCollider>().enabled = true;

            pgram.GetComponent<SphereCollider>().enabled = true;
            pgram.GetComponent<SpriteRenderer>().enabled = true;
            questGiven = true;
        }
        else
        {
            GameController.Instance.sayPriest("GO, YOU ARE AWAITED");
        }
            

    }
}
