using UnityEngine;
using System.Collections;

public class pentagram : MonoBehaviour {

    void OnTriggerEnter (Collider other) {
        Destroy(other.gameObject);
        Destroy(this.gameObject);
        GameController.Instance.updateObj(666);
    }
}
