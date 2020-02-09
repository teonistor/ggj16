using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {
    public Dictionary<string, int> inventory = new Dictionary<string, int>();
    public new GameObject camera;
    public new Light light;

    public GameObject playerCamera;
    public GameObject textBox;
    public Text textText;

    public GameObject playerPic;
    public GameObject priestPic;

    public Text objectives;

    public bool outside;
    public int score = 0;

    // Game Instance Singleton
    public static GameController Instance { get; private set; }

    private void Awake () {
        if (Instance != null && Instance != this) {
            Destroy(gameObject);
        } else {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Update () {

        if (outside) {
            camera.SetActive(false);
            playerCamera.SetActive(true);
        }
        if (Input.GetKey("space")) {
            textBox.SetActive(false);
        }
    }

    public void say (string msg) {
        textBox.SetActive(true);
        priestPic.SetActive(false);
        playerPic.SetActive(true);
        textText.text = msg;
    }

    public void sayPriest (string msg) {
        textBox.SetActive(true);
        priestPic.SetActive(true);
        playerPic.SetActive(false);
        textText.text = msg;
    }


    public void updateObj (int stage) {
        if (stage == 0) objectives.text = "Objectives\n-Find the key\n-Complete the ritual";
        if (stage == 1) objectives.text = "Objectives\n-Go to the church\n-Complete the ritual ";
        if (stage == 2) objectives.text = "Objectives\n-Complete the ritual ";
        if (stage == 666) {
            objectives.text = "RITUAL\nCOMPLETED";
            StartCoroutine(waitAndQuit(3f));
        }
    }

    private IEnumerator waitAndQuit (float t) {
        yield return new WaitForSeconds(t);
        Application.Quit();
    }
}
