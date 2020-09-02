using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SizeChanger : MonoBehaviour
{
    public GameObject BodyPart;
    public Slider SizeSlider;
    public void sizeChanger()
    {
        float newSizeValue = SizeSlider.value;
        BodyPart.transform.localScale = new Vector2(newSizeValue, newSizeValue);
    }
}
