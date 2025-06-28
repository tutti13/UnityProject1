using UnityEngine;

public class HeartController : MonoBehaviour
{
    public GameObject blockx;
    public GameObject blocky;
    public GameObject heart;
    float axisH = 0.0f;
    bool flag = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb = heart.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;  //èdóÕÇ»ÇµÇ…Ç∑ÇÈ
        var x = blockx.transform.position.x;
        var y = blocky.GetComponent<SpriteRenderer>().bounds.extents.y;
        Vector2 vec = new Vector2(x, y);

        heart.transform.position = vec;
        Debug.Log(heart.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        axisH = Input.GetAxisRaw("Horizontal");
        Rigidbody2D rb = heart.GetComponent<Rigidbody2D>();

        if (Input.GetButtonDown("Jump"))
        {
            rb.gravityScale = 1.0f;  //èdóÕÇ†ÇËÇ…Ç∑ÇÈ
            flag = true;
        }

    }

    void FixedUpdate()
    {
        Rigidbody2D rb = heart.GetComponent<Rigidbody2D>();
        if(flag == false)
        {
            rb.linearVelocity = new Vector2(3 * axisH, rb.linearVelocity.y);
        }

    }
}
