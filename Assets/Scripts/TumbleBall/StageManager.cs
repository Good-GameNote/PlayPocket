using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    private void Awake()
    {
        if(GameManager.Instance)
        {
            Dyestuffs.Instance.TakeDifficulty(GameManager.Instance.DifficultyLevel);
        }else//테스트
        {
            Dyestuffs.Instance.TakeDifficulty(1);
        }
    }
}
