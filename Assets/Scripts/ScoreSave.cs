using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSave : MonoBehaviour
{
    public Text Score;

    void Update()
    {
        Score.text = Scores.PlatformScore.ToString();
    }

}
