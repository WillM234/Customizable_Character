using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColorChanger : MonoBehaviour
{
    public GameObject BodyShape;
    private SpriteRenderer SRenderer;
    public Slider ColorSlider;
    private void Awake()
    {
        SRenderer = BodyShape.GetComponent<SpriteRenderer>(); 
    }
    public void colorChanger()
    {
        float newColorValue = ColorSlider.value;
        SRenderer.color = new Color(newColorValue,1f,1f,1f);
    }

}
