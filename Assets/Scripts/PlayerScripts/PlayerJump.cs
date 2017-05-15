using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour {

    [SerializeField]
    public  AudioClip jumpClip;
    new AudioSource audio;
    private float jumpForce = 12f, forwardForce = 0f;
    private Rigidbody2D myBody;
    private bool canJump;
    private Button jumpBtn;
    private int i;
   private CircleCollider2D circle;
    bool flag;
    private bool JumpKeyPressed;
    private int JumpsMade;
    private void Start()
    {
        JumpsMade = 0;
        JumpKeyPressed = false;
    }
    void Awake () {
        myBody = GetComponent<Rigidbody2D>();
        jumpBtn = GameObject.Find("Jump Button").GetComponent<Button>();
       jumpBtn.onClick.AddListener(() => Jump());
        circle = GetComponent<CircleCollider2D>();
        audio = GetComponent<AudioSource>();

    }
     void OnTriggerEnter2D(Collider2D collision)
    {

        canJump = true;
        i = 0;
       JumpsMade = 0;
    }
    void Update () {
        if (myBody.position.x <= -2f)
        {
            forwardForce = 1f;
        }
        else
        {
            forwardForce = 0f;
        }
        if (Input.GetKeyDown("q") && Scorescript.NoOfJumps > 0 )
        {
            JumpKeyPressed = true;
            Scorescript.NoOfJumps -= 1;
        }

    }
    
    public void Jump()
    {
            if ((canJump || i < 2 || JumpKeyPressed) && (JumpsMade < 3))
            {
                myBody.velocity = new Vector2(forwardForce, jumpForce);
            audio.PlayOneShot(jumpClip, 0.7f);
            canJump = false;
            if (!JumpKeyPressed)
            {
                i++;
            }
            forwardForce = 0f;
            JumpsMade++;
            JumpKeyPressed = false;
            }
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 70, 100, 30), "TripleJumps: " + Scorescript.NoOfJumps);
    }
}
