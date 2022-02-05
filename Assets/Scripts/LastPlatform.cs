using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPlatform : MonoBehaviour
{

    public Game Game;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Scores.PlatformScore++;
            Game.GameWon(); }
    }
}
