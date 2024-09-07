using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class malpungsun : MonoBehaviour
{
    [SerializeField] Text textBox;
    [SerializeField] ContentSizeFitter fitter;
    [SerializeField] RectTransform thisRect;

    float duration = 1.0f;
    public void OnSubmit(string message)
    {
        textBox.text = message;
    
        gameObject.SetActive(true);
        fitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        LayoutRebuilder.ForceRebuildLayoutImmediate(textBox.rectTransform);
        if (textBox.rectTransform.sizeDelta.x > 450)
        {
            fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
            textBox.rectTransform.sizeDelta = Vector2.right * 450;
        }
        LayoutRebuilder.ForceRebuildLayoutImmediate(textBox.rectTransform);
        thisRect.sizeDelta = textBox.rectTransform.sizeDelta;

        duration = 1.0f+ thisRect.sizeDelta.y/200;

    }


    private void Update()
    {
        if(duration > 0.0f) {
            duration-=Time.deltaTime;
        }
        else
        {
           gameObject.SetActive(false);
        }
    }
}
