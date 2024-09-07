
using UnityEngine;

using UnityEngine.UI;

public abstract class Dyestuff : MonoBehaviour
{
    public enum EType
    {
        gray,
        red,
        green,
        blue,
    }
    [SerializeField] Slider slider;
    float gage;
    [SerializeField] protected PhysicsMaterial2D material;
    public abstract void Create(LineRenderer lr, EdgeCollider2D ec);

    public abstract void SetColor(Image img);

    public void Charge(float _gage)
    {
        gage=  _gage;
        slider.value = gage / 500;
        Image fillImage = slider.fillRect.GetComponent<Image>();
        SetColor(fillImage);
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
        slider.value = gage / 500;


        return true;
    }

    [SerializeField] Button selectButton;


    private void Start()
    {
        selectButton.onClick.AddListener(() => { Dyestuffs.Instance.Sellect(this); });
    }

}
