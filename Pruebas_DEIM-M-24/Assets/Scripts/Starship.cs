using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starship : MonoBehaviour
{

    //Vector3 initPos = new Vector3(0f, 1f, 0f);
    public Vector3 initPos; 

    int n = 0;
    public float speed;
    float rotationSpeed = 1;

    float moveX;
    public float moveY;
    public float rotation;

    float giro;

    //Nombre del eje para movimiento horizontal
    public string hAxis = "Horizontal";

//Rigidbody rb ;

    // Start is called before the first frame update
    void Start()
    {
        //rb = gameObject.GetComponent<Rigidbody>();
        //rb.useGravity = false;


        //print(initPos);

        gameObject.transform.position = initPos;   
        
        gameObject.transform.localScale = Vector3.one * 2;

        transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        MoveStarship();
        RotateStarship();

        if(Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }

    }

    void MoveStarship()
    {


        //Variables que reciben los valores de los ejes configurados en Unity
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

       // Vector3 despl = Vector3.right * moveX + Vector3.forward * moveY;

        //transform.Translate(Vector3.forward * moveY * speed * Time.deltaTime);
        //transform.Translate(Vector3.right * moveX * speed * Time.deltaTime, Space.World);
       //transform.Translate(despl * Time.deltaTime * speed);
       
        //Muevo al jugador en cada dirección
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed);
        
    }

    void RotateStarship()
    {
        //He creado dos ejes nuevos, Rotation y Girar, para girar en Z y en Y
        rotation = Input.GetAxis("Rotation");
        giro = Input.GetAxis("Girar");

        transform.Rotate(Vector3.forward * rotationSpeed * 360f * Time.deltaTime * -rotation);
        transform.Rotate(Vector3.up * rotationSpeed * 360f * Time.deltaTime * -giro);

    }

    void Shoot()
    {
        print("PUM");
    }
}
