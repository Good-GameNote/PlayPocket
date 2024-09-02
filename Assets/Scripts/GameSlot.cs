using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSlot : MonoBehaviour
{
    [SerializeField] MiniGame game;
    private void Awake()
    {
        Image Cover = gameObject.GetComponent<Image>();
        Cover.sprite = game.Cover;

        Button button = gameObject.GetComponent<Button>();

        button.onClick.AddListener(() =>
        {
            UI_OutLine.Instance.TakeGameData(game);
        });
    }
}
