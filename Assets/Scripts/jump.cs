using UnityEngine;

public class jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce = 5.0f;
    public bool _isGrounded;

    //public Transform spawnPos;
    //public GameObject box;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Death"))
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        IsGroundedUpate(collision, false);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        IsGroundedUpate(collision, true); ;
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        JumpLog();
    }

    private void IsGroundedUpate(Collision2D collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            _isGrounded = value;
        }
    }

    void JumpLog()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isGrounded)
            {
                rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
        }
    }

}