using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Controller : MonoBehaviour {

    public UIPanel Inventory_Panel;

    public UISprite Inventory_Sprite;
    public UILabel Inventory_Label;

    public int Cha_Count_In_Inventory = 0;


    private void Awake()
    {
        Inventory_Sprite.spriteName = "None";
        Inventory_Label.text = string.Format("{0:n0}", Cha_Count_In_Inventory);
    }

    public void Check_Count_Cha()
    {
        Inventory_Label.text = string.Format("{0:n0}", Cha_Count_In_Inventory);
    }


}
