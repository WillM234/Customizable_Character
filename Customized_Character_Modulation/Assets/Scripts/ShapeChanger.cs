using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShapeChanger : MonoBehaviour
{
    public GameObject BodyPart;
    public Slider ShapeSlider;
    public Sprite Circle;
    public Sprite Square;
    public Sprite Triangle;
    private SpriteRenderer SRend;
    private void Awake()
    {
        SRend = BodyPart.GetComponent<SpriteRenderer>();
    }
    public void ChangeShape()
    {
     if(ShapeSlider.value == 1)
        {
            SRend.sprite = Circle;
        }
     if(ShapeSlider.value == 2)
        {
            SRend.sprite = Square;
        }
     if(ShapeSlider.value == 3)
        {
            SRend.sprite = Triangle;
        }
    }
}
