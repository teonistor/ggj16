using UnityEngine;
using System.Collections;

public class ChurchStart : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        GameController.Instance.updateObj(2);
    }
}
