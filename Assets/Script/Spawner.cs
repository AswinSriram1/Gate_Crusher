using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] gates;
    float z;
    int n;

    void Start()
    {
        n = Random.Range(0, gates.Length);
        //z = Random.Range(0f, 60f);
        InvokeRepeating("spawn", 3, 1);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawn()
    {
        Instantiate(gates[n],transform.position,transform.rotation*Quaternion.Euler(0,0,Random.Range(-50,50))) ;
    }
}
