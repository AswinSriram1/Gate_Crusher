using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    Camera myCamera;
    [SerializeField] [Range(0f, 1f)] float lerpTime;
    [SerializeField] Color[] myColor;
    int colorIndex;
    float t = 0f;
    int len;
    // Start is called before the first frame update
    void Start()
    {
        myCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        len = myColor.Length;
    }

    // Update is called once per frame
    void Update()
    {
        myCamera.backgroundColor = Color.Lerp(myCamera.backgroundColor, myColor[colorIndex], lerpTime);
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= myColor.Length) ? 0 : colorIndex;
        }
    }
}
