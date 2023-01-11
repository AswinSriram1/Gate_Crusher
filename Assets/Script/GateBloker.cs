using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateBloker : MonoBehaviour
{
    //[SerializeField] public GameObject Ball;
    // Start is called before the first frame update
    [SerializeField] public GameObject gameoverPannel;
    //public Animator anim;

    void Start()
    {
        //gameoverPannel.SetActive(false);
        //anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            //Debug.Log("Game Over");
            //anim.Play();
            //anim.Play("Animation");
            Vibration.Vibrate(500);
            gameoverPannel.SetActive(true);
            StartCoroutine("endgame");
            //Time.timeScale = 0;
            
        }
    }
    IEnumerator endgame()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0;
    }
}
