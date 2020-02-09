using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    private static GameController instance = null;
    public Dictionary<string, int> inventory = new Dictionary<string, int>();
    public GameObject camera;
    public Light light;

    public GameObject playerCamera;
    public GameObject textBox;
    public Text textText;

    public GameObject inventoryShow;
    public GameObject inventoryText;

    public GameObject playerPic;
    public GameObject priestPic;

    public Text objectives;
  
    public bool outside;
    public int score=0;

    // Game Instance Singleton
    public static GameController Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
   
        if (outside)
        {
            camera.SetActive(false);
            playerCamera.SetActive(true);
        }
        if (Input.GetKey("space"))
        {
            textBox.SetActive(false);
            showInventory(false);
        }

        if (Input.GetKeyDown("i"))
        {
            showInventory(true);
        }
    }

    public void say(string msg)
    {
        textBox.SetActive(true);
        priestPic.SetActive(false);
        playerPic.SetActive(true);
        textText.text = msg;
    }

    public void sayPriest(string msg)
    {
        textBox.SetActive(true);
        priestPic.SetActive(true);
        playerPic.SetActive(false);
        textText.text = msg;
    }

    public void showInventory(bool isShown)
    {
        inventoryShow.SetActive(isShown);
        Text textInv = inventoryText.GetComponent<Text>();
        textInv.text = "";
        foreach (KeyValuePair<string, int> entry in inventory)
        {
            textInv.text += entry.Key + " : " + entry.Value;
        }

    }

    public void updateObj(int stage){
        if (stage == 0) objectives.text = "Objectives\n-Find the key\n-Complete the ritual";
        if( stage == 1) objectives.text = "Objectives\n-Go to the church\n-Complete the ritual ";
        if (stage == 2) objectives.text = "Objectives\n-Complete the ritual ";
        if (stage == 666) objectives.text = "RITUAL\nCOMPLETED";
    }
}