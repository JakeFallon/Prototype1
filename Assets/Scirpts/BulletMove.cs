using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    [SerializeField] private float time = 3f;
    private Rigidbody2D rb;
    private EnemySpawner spawner;
    [SerializeField] int pointvalue = 1000;
    
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Straight();
        Destroy();
        
    }
    private void Straight()
    {
        rb.linearVelocity = transform.right * speed;
    }

    private void Destroy()
    {
        Destroy(gameObject, time);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(coll.gameObject);
            GameManager.IncrementScore(pointvalue);
            
        } 
    }


}
