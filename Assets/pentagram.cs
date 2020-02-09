using UnityEngine;
using System.Collections;

public class pentagram : MonoBehaviour
{
    public Door roomDoor;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(this.gameObject);
        GameController.Instance.updateObj(666);
        Application.Quit();
    }
}
