using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UI_OutLine : Singleton<UI_OutLine>
{
    [SerializeField] Image cover;
    [SerializeField] Text title;
    [SerializeField] Text summary;

    [SerializeField]  GameObject[] IsSingle;

    [SerializeField] Text highPoint;
    MiniGame _game;

    int DifficultyLevel;
    public void ChangeLevel(int level)
    {
        DifficultyLevel = level;
    }
    public void TakeGameData(MiniGame game)
    {
        cover.sprite = game.Cover;
        title.text = game.Title;
        summary.text = game.Summary;

        IsSingle[0].SetActive(game.IsSingle);
        IsSingle[1].SetActive(!game.IsSingle);

        highPoint.text = PlayerPrefs.GetInt($"{ game.Title}_{DifficultyLevel}").ToString();

        _game = game;

        gameObject.SetActive(true);

    }
 
    public void Sellect(bool isBot)
    {

        GameManager.Instance.GotoGame(_game, DifficultyLevel,isBot);
    }

}
