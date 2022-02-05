using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour
{
    public static int PlatformScore;
    public static int StarScore;
    public static int HighScore;
    public static int ComboCount;

    public static void Combo()
    {
        ComboCount++;
        PlatformScore += ComboCount * 2;
    }
}
