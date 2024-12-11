using System;
using UnityEngine.Tilemaps;
using UnityEngine;

public class MovJugador : MonoBehaviour
{
    //Le damos el cuerpo que va a mover desde antes para que no lo tenga que buscar a cada rato
    public Rigidbody2D body;
    public float xSpeed;
    public float salto;
    [Range(0f,1f)]
    public float friccionSuelo;
    public BoxCollider2D groundCheck;

    public LayerMask groundMask;
    public LayerMask PlatformMask;

    public TilemapRenderer tilemap;
    public bool grounded;

    public bool groundedPlatform;


    float xInput;
    float yInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tilemap = GetComponent<TilemapRenderer>();
    }

    // Update is called once per frame
        void Update()
    {
        //le damos los inputs que necesita para saber como tiene que moverse
        //float yInput  = Input.GetAxis("Vertical");
        getInput();
        //Caminata
        if (Math.Abs(xInput)>0){
        body.linearVelocity = new Vector2(xInput*xSpeed,body.linearVelocity.y);
        }
        //salto

        if (Math.Abs(yInput)>0 && grounded){
            body.linearVelocity = new Vector2(body.linearVelocity.x,salto);
        }

        //body.linearVelocity = direction*xSpeed;
    }

    void FixedUpdate(){
        checkGround();
        ApplyFriction();
    }

    void checkGround(){
        grounded = Physics2D.OverlapAreaAll(groundCheck.bounds.min, groundCheck.bounds.max,groundMask).Length >0;
    }



    void getInput(){
        xInput  = Input.GetAxis("Horizontal");
        yInput  = Input.GetAxis("Vertical");
    }

    void ApplyFriction(){
        //Esto es para la fricción
        if (grounded && xInput == 0 && yInput == 0){
            body.linearVelocity = body.linearVelocity*friccionSuelo;
        }
    }
}
