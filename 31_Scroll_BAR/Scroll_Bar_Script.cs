using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_Bar_Script : MonoBehaviour {

    public UISlider Slider_Bar_Sprite;

    public void aa()
    {
       if (  Slider_Bar_Sprite.value <= 0.15f)
        {
            Slider_Bar_Sprite.value = 0.15f;

        }    
    }
    

}
