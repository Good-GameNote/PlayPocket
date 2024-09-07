using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dyestuff_Gray : Dyestuff
{
    public override void Create(LineRenderer lr, EdgeCollider2D ec)
    {
        lr.startColor = Color.gray;
        lr.endColor = Color.gray;
        ec.sharedMaterial = material;
    }

    public override void SetColor(Image img)
    {
        img.color = Color.gray;
    }
}
