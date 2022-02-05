using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsSave : MonoBehaviour
{
    public Text Star;

    void Update()
    {
        Star.text = Scores.StarScore.ToString();
    }
}
