using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreSave : MonoBehaviour
{
    public Text HighScore;

    void Update()
    {
        HighScore.text = "High Score " + Scores.HighScore.ToString();
    }

}
