using System.Collections;
using UnityEngine;

public class move : MonoBehaviour
{
    public Animator anim;
    public float moveSpeed = 0.3f;
    public float maxSpeed = 5f;
    private Rigidbody2D rb;
    private float speed = 0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        StartCoroutine(wait());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("TrigExitJump");
        }

        else if (rb.velocity.x != 0f)
        {
            anim.SetTrigger("TrigRun");
        }
        else
        {
            anim.SetTrigger("TrigStop");
        }
    }

    void FixedUpdate()
    {
        if (rb.velocity.x < maxSpeed)
        {
            rb.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3f);
        speed = moveSpeed;
    }
}