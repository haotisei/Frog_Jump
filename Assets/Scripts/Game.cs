using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static GameState gameState;
    public GameObject GameLostScreen;
    public GameObject GameWonScreen;
    public GameObject GameOnScreen;

    public enum GameState
    {
        Menu,
        Playing,
        Won,
        Loss,
    }

    public void GameOver()
    {
        gameState = GameState.Loss;
        GameOnScreen.SetActive(false);
        GameLostScreen.SetActive(true);
    }

    public void GameWon()
    {
        gameState = GameState.Won;
        GameOnScreen.SetActive(false);
        GameWonScreen.SetActive(true);
    }
}
