using UnityEngine;

public class GarbageController : MonoBehaviour
{
    
    void OnTriggerEnter2d(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
