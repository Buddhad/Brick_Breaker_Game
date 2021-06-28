using UnityEngine;

public class Jump : MonoBehaviour
{
    public bool inPlay;
    public Transform paddle;
    public Rigidbody2D rb;
    public float speed;
    public GameManager gm;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce (Vector2.up * speed);

    }
    // Update is called once per frame
    void Update()
    {
        BallInTop();
        
    }

    void BallInTop()
    {
        if (gm.gameOver)
        {
            return;
        }
        if (!inPlay)
        {
            transform.position = paddle.position;
           
        }
        if (Input.GetButtonDown("Jump") && !inPlay)
        {
            inPlay = true;
            rb.AddForce(Vector2.up * speed);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("brick"))
        {
            gm.Updatescore (other.gameObject.GetComponent<BrickScript>().points);

            Destroy(other.gameObject);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Destroy"))
        {
            rb.velocity = Vector2.zero;
            //Debug.Log("Ball Hit the bottom");
            inPlay = false;
            gm.Updatelives(-1);
        }
    }

}
