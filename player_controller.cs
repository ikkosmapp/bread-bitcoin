using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {
    public float maxSpeed = 5f;
    public float speed = 2f;
    private Rigidbody2D rb2d;
    bool tocando;
    public GameObject player;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary )
      //  {
      //      Vector3 touchPosition = Input.GetTouch(0).position;
       //     Vector2 touchPosition2 = Input.mousePosition;
//
       //     double halfScreen = Screen.width / 2.0;
       //     //Check if it is left or right?
       //     if (touchPosition.x < halfScreen || touchPosition2.x < halfScreen)
       //     {
        //        player.transform.Translate(Vector3.left * 5 * Time.deltaTime);
        //    }
         //   else if (touchPosition.x > halfScreen || touchPosition2.x > halfScreen)
       //     {
        //        player.transform.Translate(Vector3.right * 5 * Time.deltaTime);
         //   }
//
      //  }
    }

    void FixedUpdate()
    {

      float h = Input.GetAxis("Horizontal");
       rb2d.AddForce(Vector2.right * speed * h);
        if (rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);

        }
        if (rb2d.velocity.x < -maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }

   }
}
