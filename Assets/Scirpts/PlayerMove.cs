using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMove : MonoBehaviour
{

    private float speed = 5f;
    private float jump = 5f;
    private float horizontal;
    private float vertical;
    [SerializeField] private Rigidbody2D rb;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //health = gameObject.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        

        
        rb.linearVelocity = new Vector2(horizontal * speed, vertical* speed);


    }


   
}
