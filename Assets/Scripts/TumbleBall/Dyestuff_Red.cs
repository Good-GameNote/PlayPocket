using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dyestuff_Red : Dyestuff
{
    public override void Create(LineRenderer lr, EdgeCollider2D ec)
    {
        lr.startColor = Color.red;
        lr.endColor = Color.red;
        ec.sharedMaterial = material;
    }

    public override void SetColor(Image img)
    {
        img.color = Color.red;
    }
}