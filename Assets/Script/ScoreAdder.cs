using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreAdder : MonoBehaviour
{
    public int scoreValue = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("point increase");
            ScoreManager.instance.AddPoints();

        }
    }
}
