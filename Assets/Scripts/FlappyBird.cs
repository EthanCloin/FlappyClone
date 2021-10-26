using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float jumpStrength = 2.5f;
    [SerializeField] private GameManager gm;
    public bool jumpInput = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.GetGameActive())
        {
            if (Input.GetKeyDown(KeyCode.Space) && gm.GetFirstJump() == false)
            {
                gm.SetFirstJump(true);
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                jumpInput = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && gm.GetFirstJump() == true)
            {
                jumpInput = true;
            }
        }
    }


    // Physics Engine Actions
    private void FixedUpdate()
    {
        if (jumpInput)
        {
            rb.velocity = Vector2.up * jumpStrength;
            jumpInput = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gm.GameOver();
    }
}
