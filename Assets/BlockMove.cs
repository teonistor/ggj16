using UnityEngine;
using System.Collections;

public class BlockMove : MonoBehaviour {
    public Rigidbody rb;
    public Animator anim;
    public float speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
       /* if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector2(0f, 5f));
            anim.SetBool("isWalking", true);
        }
       else
              anim.SetBool("isWalking",false);
        if (Input.GetKey("s"))
              rb.AddForce(new Vector2(0f, -5f));
        if (Input.GetKey("a"))
              rb.AddForce(new Vector2(-5f, 0f));
        if (Input.GetKey("d"))
              rb.AddForce(new Vector2(5f, 0f));
        */
       
	}


	void FixedUpdate () {
		float x = Input.GetAxis ("Horizontal");
        float y = Input.GetAxis ("Vertical");
        rb.velocity = new Vector3(x * speed, y * speed, 0f);
        anim.SetBool("isWalking",   (x != 0f || y != 0f));
        anim.SetBool("isWalkingUp", (y > 0f));
        anim.SetBool("isWalkingDown", (y < 0f));

        anim.SetBool("isWalkingLeft", (x < 0f));
        anim.SetBool("isWalkingRight", (x > 0f));
        

	}
}