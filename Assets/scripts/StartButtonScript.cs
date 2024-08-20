using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

class StartButtonEventHandler : MonoBehaviour
{
    Color buttonColor;
    Image buttonImage;
    public float alpha = 0.85f;

    private void Start()
    {
        buttonImage = GetComponent<Image>();

        buttonColor = buttonImage.color;
    }

    public void DimButton(){
        Color dimmedColor = buttonColor;
        dimmedColor.a = alpha;
        buttonImage.color = dimmedColor;
    }
    public void UndimButton()
    {
        buttonImage.color = buttonColor;
    }

    public void ScaleDown()
    {
        buttonImage.transform.localScale.Set(0.5f, 0.5f, 1.0f);
    }

    public void ScaleUp()
    {
        this.transform.localScale.Set(1.0f, 1.0f, 1.0f);
    }
}