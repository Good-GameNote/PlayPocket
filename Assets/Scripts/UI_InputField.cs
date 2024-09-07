using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_InputField : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.InputField field;
    [SerializeField] malpungsun pungsun;
    private void Awake()
    {
        field.onSubmit.AddListener((text) => {
            pungsun.OnSubmit(text); 
            field.text =string.Empty;
        });
    }
}
