using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dyestuffs : Singleton<Dyestuffs>
{
    [SerializeField] Dyestuff[] prefab;


    
    //List<Dyestuff> list = new List<Dyestuff>();

    public Dyestuff CurDystuff { get; private set; }
    //난이도에 따른 물감생성
    public void TakeDifficulty(int level)
    {
        Dyestuff newDyestuff = Instantiate(prefab[0],transform);
        newDyestuff.Charge( 250);

       // list.Add(newDyestuff);
        CurDystuff = newDyestuff;

        //todo: 난이도별로 물감종류나 양 조절해야함
        newDyestuff = Instantiate(prefab[1], transform);
        newDyestuff.Charge( 450);

      //  list.Add(newDyestuff);

        newDyestuff = Instantiate(prefab[2], transform);
        newDyestuff.Charge( 350);

        //   list.Add(newDyestuff);

        newDyestuff = Instantiate(prefab[3], transform);
        newDyestuff.Charge(150);

    }

    //현재 선택된 색상
    public void Sellect(Dyestuff dyestuff)
    {
        CurDystuff = dyestuff;
    }

    public bool Drawing(float value)
    {
        return CurDystuff.Drawing(value);
    }




}
