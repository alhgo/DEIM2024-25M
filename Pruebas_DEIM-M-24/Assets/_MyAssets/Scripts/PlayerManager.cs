using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] int lifes = 4;
    public float shield;
    bool alive;
   // float damage;
    bool powerUp;

    //Variables de inicio de juego
    int vidasIniciales = 4;
    float escudoInicial = 100f;

    private void Start()
    {
        StarGame();
    }

    // Update is called once per frame
    void Update()
    {
        DetectarInputs();

    }

    void DetectarInputs()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive == true)
        {
            Impact();
        }

        if (Input.GetKeyUp(KeyCode.Escape) && alive == false)
        {
            StarGame();

        }
    }

    void StarGame()
    {
        lifes = vidasIniciales;
        shield = escudoInicial;
        alive = true;
        powerUp = false;
        print("Comienza el juego!");
    }

    float CalcularDamage()
    {
        //damage = 25f;
        //Calculo el daño al azar
        float x = Random.Range(10f, 60f);
        x = Mathf.Round(x * 10)/10;
        return x;
    }

    void Impact()
    {
        //Declaro una variable local
        float damage;
        //Le doy el valor que me retorna el método de calcular daño
        damage = CalcularDamage();
        print("Has recibido un impacto con un daño de " + damage);
        shield -= damage;
        if(shield < 0)
        {
            RestarVida();
        }
        else
        {
            print("Te queda de escudo " + shield);
        }

        //print("te queda de escudo " + shield);
    } 

    void RestarVida()
    {
        lifes--;
        if(lifes <= 0)
        {
            Die();
        }
        else
        {
            shield = escudoInicial;
            print("Te han quitado una vida. Te quedan " + lifes);
            BuclePorLaVida();
        }
    }

    void BuclePorLaVida()
    {
        for(int i = 0; i < lifes; i++)
        {
            print("Bucle por la vida " + i);

        }
    }

    void Die()
    {
        print("Estás muerto. Pulsa Escape para empezar de nuevo");
        alive = false;
    }


}
