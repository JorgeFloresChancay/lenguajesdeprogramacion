using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Rigidbody2D myrigidbody2D;
    public GameManager myGameManager;
    public float bulletSpeed = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        myGameManager = Object.FindFirstObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        myrigidbody2D.linearVelocity = new Vector2(bulletSpeed,myrigidbody2D.linearVelocity.y);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("ItemGood"))
        {
            Destroy(collision.gameObject);
        }
        else if(collision.CompareTag("ItemBad"))
        {
            myGameManager.AddScore();
            Destroy(collision.gameObject);
        }
    }
}
