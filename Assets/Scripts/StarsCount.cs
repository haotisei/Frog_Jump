using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsCount : MonoBehaviour
{
    public GameObject Star;
    void OnCollisionEnter(Collision other)
    {
        Star.SetActive(false);
        Scores.StarScore++;
        Debug.Log(Scores.StarScore);
    }

}
