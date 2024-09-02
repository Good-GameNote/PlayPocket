using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Common;




[CreateAssetMenu(fileName = "MiniGameData", menuName = "MiniGameData")]
public class MiniGame : ScriptableObject
{
    [field:SerializeField] public Sprite Cover { get; private set; }

    [field: SerializeField] public string Title { get; private set; }

    [field: SerializeField] public string Summary { get; private set; }


    [field: SerializeField] public bool IsSingle { get; private set; }

    [field: SerializeField] public bool IsNonDifficulty { get; private set; }

    [field: SerializeField] public bool IsPuzzle { get; private set; }

    [field: SerializeField] public bool IsSimulation { get; private set; }


}
