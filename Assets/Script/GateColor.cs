using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateColor : MonoBehaviour
{
    public Material[] mat;
    //public int x;
    MeshRenderer meshRend;
    // Start is called before the first frame update
    void Start()
    {
        //Color color = new Color(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1), 1);
        //mat[] = Random.Range[0, mat.Length];
        meshRend = GetComponent<MeshRenderer>();
        meshRend.material = mat[Random.Range(0,mat.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
