using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    Vector3 lastTapPos;
    //Vector3 startRotation;
    [SerializeField] public float speed = 5f;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        //startRotation = transform.localEulerAngles;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 curTapPos = Input.mousePosition;
            if(lastTapPos == Vector3.zero)
            {
                lastTapPos = curTapPos;
            }
            lastTapPos = curTapPos;
            float delta = lastTapPos.z - curTapPos.x;

            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, delta);
            /*if (delta > 0)
            {
                transform.Rotate(0, 0, 2);
            }
            else
            {
                transform.Rotate(0, 0, -2);
            }*/
            
            if (Input.GetMouseButtonUp(0))
            {
                lastTapPos = Vector2.zero;
            }
        }
    }

    void FixedUpdate()
    {
        transform.Translate(0,0,speed*Time.deltaTime);
    }

}
