using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dyestuffs : Singleton<Dyestuffs>
{
    [SerializeField] Dyestuff prefab;

    List<Dyestuff> list;

    //난이도에 따른 물감생성
    public void TakeDifficulty(int level)
    {
        Dyestuff newDyestuff = Instantiate(prefab);
        newDyestuff.Setting(Dyestuff.EType.gray, 150);

    }

    int sellectedDyestuffIdx;
    //현재 선택된 색상
    public void Sellect(int idx)
    {
        sellectedDyestuffIdx = idx;
    }

    public bool Drawing(float value)
    {
        return list[sellectedDyestuffIdx].Drawing(value);
    }




}
