using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Room_Script_01 : MonoBehaviour {
    public BoxCollider Box_Collider_On_Off;
    public UIButton UiButton_On_Off;
    public UISprite Box_UI_Sprite;

    //선택 전의 방 이미지 
    private string Num_Zero_Box_BG = "Box_BG_00";



        
    public void Room_On()
    {
        Box_Collider_On_Off.enabled = true;
        UiButton_On_Off.SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite.spriteName = Num_Zero_Box_BG;
        UiButton_On_Off.normalSprite = Num_Zero_Box_BG;
    }
    /*
    public void Room_Off()
    {
        Box_Collider_On_Off.enabled = false;
    }
    */
}
