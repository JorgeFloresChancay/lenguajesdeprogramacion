using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{

    public float playerJumpForce = 20f;
    public float playerSpeed = 10f;
    public Sprite[] mySprites;
    private int index=0;
    private int hitCount = 0; public int maxHits = 3;

    private Rigidbody2D myrigidbody2D;
    private SpriteRenderer mySpriteRenderer;
    public GameObject Bullet;
    public GameManager myGameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        //StartCoroutine(WalkCoRoutine());
        myGameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
         // Obtener la entrada del jugador
        float move = 0f;

        if (Input.GetKey(KeyCode.D))
        {
            move = 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            move = -1f;
        }

        // Mover el jugador
        transform.Translate(Vector3.right * move * playerSpeed * Time.deltaTime);
    }

    /*IEnumerator WalkCoRoutine()
    {
        yield return new WaitForSeconds(0.05f);
        mySpriteRenderer.sprite = mySprites[index];
        index++;
        if(index==6)
        {
            index = 0;
        }
        StartCoroutine(WalkCoRoutine());
    }*/

 
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ItemBad"))
        {
            hitCount++;
            if (hitCount >= maxHits)
            {
                // Perder el juego
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }


    void PlayerDeath()
    {
        SceneManager.LoadScene("SampleScene");
    }
}


