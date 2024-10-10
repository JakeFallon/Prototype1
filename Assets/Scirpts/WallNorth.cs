using System;
using System.Runtime.CompilerServices;
//using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class WallNorth : MonoBehaviour
{

    private float speed = 3f;
    private float horizontal;
    [SerializeField] private Rigidbody2D wb;
    private int ran;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("RandomNumber", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {







        if (gameObject.transform.position.y <= 0)
        {
            gameObject.transform.position = new Vector2(0f, 5f);
            wb.linearVelocity = new Vector2(-0f, 0f);
        }

    }

    void RandomNumber()
    {
        int ran = UnityEngine.Random.Range(0, 5);
        

        if (ran == 3)
        {
            wb.linearVelocity = new Vector2(0f, -speed);


        }
    }





}
