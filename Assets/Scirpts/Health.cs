using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    [SerializeField] public float PlayerHealth;
    [SerializeField] public Slider HealthBar;
    GameManager manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerHealth = 5;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.value = PlayerHealth;

        if (PlayerHealth <= 0 ) 
        {
          
            //UnityEditor.EditorApplication.isPlaying = false;g
            Application.Quit();
        }
    }


    private void OnCollisionEnter2D(UnityEngine.Collision2D coll)
    {
        if (coll.gameObject.name == "WallWest")
        {
            PlayerHealth = PlayerHealth - 1;
            Debug.Log(PlayerHealth);


        }
        if (coll.gameObject.name == "WallEast")
        {
            PlayerHealth = PlayerHealth - 1;
            Debug.Log(PlayerHealth);


        }
        if (coll.gameObject.name == "WallNorth")
        {
            PlayerHealth = PlayerHealth - 1;
            Debug.Log(PlayerHealth);


        }
        if (coll.gameObject.tag == "Enemy")
        {
            PlayerHealth = PlayerHealth - 1;
            Debug.Log(PlayerHealth);

        }
    }

    
}
