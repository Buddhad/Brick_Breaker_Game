using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 5f;
    [SerializeField]
    private float leftScreenEdge;
    [SerializeField]
    private float rightScreenEdge;
    public GameManager gm;

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        
        ScreenBlock();
    }

    void PlayerMoveKeyboard()
    {
        if (gm.gameOver)
        {
            return;
        }
        float movementx = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * movementx * Time.deltaTime * moveForce);
    }
    void ScreenBlock()
    {
        if (transform.position.x < leftScreenEdge)
        {
            transform.position = new Vector2(leftScreenEdge, transform.position.y);
        }
        if (transform.position.x > rightScreenEdge)
        {
            transform.position = new Vector2(rightScreenEdge, transform.position.y);
        }
       
    }


}
