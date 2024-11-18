using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] GameObject player;

    //Vector 3 que indica la separación respecto al jugador
    [SerializeField] Vector3 offset = new Vector3(0f, 2, -3.5f);

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        print(player.transform.position);
        Vector3 desiredPosition = player.transform.position + offset;
        transform.position = desiredPosition;
        transform.LookAt(player.transform);
    }
}
