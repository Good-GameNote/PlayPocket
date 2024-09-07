using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dyestuff_Blue : Dyestuff
{
    public override void Create(LineRenderer lr, EdgeCollider2D ec)
    {
        lr.startColor = Color.blue;
        lr.endColor = Color.blue;
        ec.sharedMaterial = material;
    }

    public override void SetColor(Image img)
    {

        img.color = Color.blue;
    }
}
