using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.UI;

public class Dyestuff : MonoBehaviour
{
    public enum EType
    {
        gray,
        red,
        green,
        blue,
    }
    [SerializeField] Slider slider;
    float originGage;
    float gage;



    public void Setting(EType _color, float _gage)
    {
        Image fillImage = slider.fillRect.GetComponent<Image>();
        switch (_color)
        {
            case EType.gray:
                fillImage.color = Color.gray;
                
                break;
            case EType.red:

                fillImage.color = Color.red;
                break;
            case EType.green:

                fillImage.color = Color.green;
                break;
            case EType.blue:

                fillImage.color = Color.blue;
                break;
        }


        gage= originGage = _gage;

    }
    public bool Drawing(float distance)
    {
        if(gage == 0f)
        {
            return false;
        }
        if(gage<distance)
        {
            gage = 0;
        }else
        {
            gage-=distance;
        }
        slider.value = gage / originGage;


        return true;
    }

    [SerializeField] Button selectButton;


    private void Start()
    {
        selectButton.onClick.AddListener(() => { Dyestuffs.Instance.Sellect(transform.GetSiblingIndex()); });
    }

}
