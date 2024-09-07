using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dyestuff_Green : Dyestuff
{
    public override void Create(LineRenderer lr, EdgeCollider2D ec)
    {
        lr.startColor = Color.green;
        lr.endColor = Color.green;
        ec.sharedMaterial = material;
    }

    public override void SetColor(Image img)
    {
        img.color = Color.green;
    }


}