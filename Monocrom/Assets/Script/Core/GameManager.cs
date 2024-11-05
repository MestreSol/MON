using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour{
    public static GameManager instance;
    public GameState gameState;
    private void Awake(){
        instance = this;
    }

    public bool InGame() {
        return gameState == GameState.InGame;
    }
    
}

public enum GameState
{
    InMenu,
    InGame
}