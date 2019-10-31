using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;
    Rigidbody2D myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
    }

    private void Run()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Value is between -1 to +1
            // create a new vector2 parameter value that only changes the x-axis velocity
            Vector2 playerVelocity = new Vector2(runSpeed, myRigidBody.velocity.y);
            // set the velocity field parameter values to be the new vector2 velocity values
            myRigidBody.velocity = playerVelocity;
            // bool that determines the animation for the player sprite when running
            bool playerHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Value is between -1 to +1
            // create a new vector2 parameter value that only changes the x-axis velocity
            Vector2 playerVelocity = new Vector2(-runSpeed, myRigidBody.velocity.y);
            // set the velocity field parameter values to be the new vector2 velocity values
            myRigidBody.velocity = playerVelocity;
            // bool that determines the animation for the player sprite when running
            bool playerHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
        }

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        // Alternate method: if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            // create a new vector2 parameter value that only changes the y-axis velocity
            Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
            // add the new vector2 parameter values to the original velocity values
            myRigidBody.velocity += jumpVelocityToAdd;
        }
    }


}

