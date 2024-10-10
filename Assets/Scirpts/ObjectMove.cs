using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ObjectMove : MonoBehaviour
{
    
   
    public GameObject target;
    
   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
    


        target = GameObject.Find("Player");
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, 3f * Time.deltaTime);

    }
}
