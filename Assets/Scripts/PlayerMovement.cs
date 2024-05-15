using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private Rigidbody2D rb;

    private Animator anim;

    private float horizontalInput = 0f;

    public CollectManager cm;

    public AudioManager2 audioPlayer; 


    // Start is called before the first frame update
    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * 7f, rb.velocity.y);

        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(rb.velocity.x, 14f);
        }

        UpdateAnimationUpdate();

    }

    private void UpdateAnimationUpdate()
    {

        if (horizontalInput > 0f)
        {
            anim.SetBool("running", true);

        }
        else if (horizontalInput < 0f)
        {
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);
        }

    }

    // Gizmo function adds a red color line 
    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.forward * 500f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectibles"))
        {
            Destroy(other.gameObject);
            cm.collectiblesCount++;
        }
    }

    


}
