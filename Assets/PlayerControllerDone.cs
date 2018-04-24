using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerDone : MonoBehaviour {

    public Rigidbody2D Rigid;
    public float JumpForce;
    public int JumpForceInt;

    public Animator Anim;

    public GameObject GameOverText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {

            Anim.SetBool("playerJumpDown", true);
           // Anim.SetBool("JumpDown", true);

        }

        if(Input.GetKeyUp(KeyCode.Space) == true)
        {
            Rigid.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            Anim.SetBool("playerJumpDown", false);
           // Anim.SetBool("JumpUp", true);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            GameOverText.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameOverText.SetActive(true);
        }
    }
}
