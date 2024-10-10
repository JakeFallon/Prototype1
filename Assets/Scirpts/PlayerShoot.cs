//using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    private PlayerMove playerMove;
    public Transform rotate;
    private Vector2 WorldPos;
    private Vector2 direction;
    private Vector2 GameObjectRotation;
    [SerializeField] private GameObject Gun;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform BulletSpawn;
    private InputSystem_Actions inputActions;
    InputAction fire;
    private PlayerInput playerInput;
    private bool Shoot;
   
    

    private GameObject bulletinst;

    private void Awake()
    {
        inputActions = new InputSystem_Actions();
        playerInput = GetComponent<PlayerInput>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputActions.Player.Attack.Enable();

    }

    // Update is called once per frame
    void Update()
    {
       
        //GunRotation();
        GunShooting();
        Shoot = false;
        aim();
        


    }

    private void Fire(InputAction.CallbackContext context)
    {
        
        Shoot = true;
       
    }

     private void GunRotation()
     {
        WorldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        direction = (WorldPos - (Vector2)Gun.transform.position).normalized;
        Gun.transform.right = direction;

     }

    private void GunShooting()
    {
        if (Shoot)
        {   
            bulletinst = Instantiate(Bullet,BulletSpawn.position,Gun.transform.rotation);
        }
    }
    private void OnEnable()
    {
        fire = inputActions.Player.Attack;
        fire.Enable();
        fire.performed += Fire;
    }

    private void OnDisable()
    {
        
        fire.Disable();
    }

    public void aim()
    {
        float HorizontalAxis = Input.GetAxis("horizontalrighstick");
        float VerticalAxis = Input.GetAxis("verticalrightstick");

        rotate.transform.localEulerAngles = new Vector3 (0f,0f,Mathf.Atan2(HorizontalAxis,- VerticalAxis) * -180 / Mathf.PI + 90);
    }
  


}


