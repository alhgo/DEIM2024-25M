using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] int lifes = 4;
    public float shield;
    bool alive;
    float damage;
    bool powerUp;

    private void Start()
    {
        lifes = 4;
        shield = 100f;
        alive = true;
        powerUp = false;
        damage = 25f;
    }

    void Impact()
    {
        print("Has recibido un impacto con un daño de " + damage);
        shield -= damage;
        if(shield < 0)
        {
            lifes--;
        }
        else
        {
            print("Te queda de escudo " + shield);
        }

        //print("te queda de escudo " + shield);
    } 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Impact();
        }

    }


}
