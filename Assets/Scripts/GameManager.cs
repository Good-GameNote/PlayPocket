using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public MiniGame Minigame { get; private set; }
    public int DifficultyLevel { get; private set; }
    public bool IsBot { get; private set; }


    public void GotoGame(MiniGame minigame,int difficultyLevel,  bool isBot)
    {
        Minigame = minigame;
        DifficultyLevel = difficultyLevel;
        IsBot = isBot;
        SceneManager.LoadScene(Minigame.Title);
    }


}