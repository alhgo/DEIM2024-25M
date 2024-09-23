using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactoAsteroide : MonoBehaviour
{
    //VARIABLES GLOBALES
    int lifes = 5;
    bool alive = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectarImpacto();


    }

    void DetectarImpacto()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && alive == true)
        {
            Impacto();
        }
    }

    void Impacto()
    {
        lifes = lifes - 1;
        if (lifes < 0)
        {
            Die();
        }
        else
        {
            BucleLifes();
        }
    }

    void BucleLifes()
    {
        for(int i = 0; i < lifes; i++)
        {
            print("Bucle por vida " + i);
        }
    }

    void Die()
    {
        print("Estás muerto");
        alive = false;
    }
}
