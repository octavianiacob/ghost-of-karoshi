using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    //Config
    [SerializeField] float runSpeed = 20f;
    [SerializeField] float jumpSpeed = 5f;
    //State
    bool isAlive = true;

    //Component references;
    Rigidbody2D playerBody;
    Animator playerAnimator;

    private void Run()
    {
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal"); // Valoare intre -1 si 1
        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, playerBody.velocity.y);
        playerBody.velocity = playerVelocity;

        bool playerHasHorizontalSpeed = Mathf.Abs(playerBody.velocity.x) > Mathf.Epsilon;
        playerAnimator.SetBool("isRunning", playerHasHorizontalSpeed);
    }

    private void Jump()
    {
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
            playerBody.velocity += jumpVelocityToAdd;
        }
    }


    private void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(playerBody.velocity.x) > Mathf.Epsilon;
        if(playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(playerBody.velocity.x), 1f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
        FlipSprite();
    }
}
