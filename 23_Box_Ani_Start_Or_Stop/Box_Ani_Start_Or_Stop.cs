using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Ani_Start_Or_Stop : MonoBehaviour {

	public UISpriteAnimation[] UI_Sprite_Ani_01;
    public UISpriteAnimation[] UI_Sprite_Ani_02;
    public UISpriteAnimation[] UI_Sprite_Ani_03;
    public UISpriteAnimation[] UI_Sprite_Ani_04;
    public UISpriteAnimation[] UI_Sprite_Ani_05;
    public UISpriteAnimation[] UI_Sprite_Ani_06;
    public UISpriteAnimation[] UI_Sprite_Ani_07;
    public UISpriteAnimation[] UI_Sprite_Ani_08;
    public UISpriteAnimation[] UI_Sprite_Ani_09;
    public UISpriteAnimation[] UI_Sprite_Ani_10;
    public UISpriteAnimation[] UI_Sprite_Ani_11;
    public UISpriteAnimation[] UI_Sprite_Ani_12;

    private void Awake()
    {
        SpriteAni_01_Off();
        SpriteAni_02_Off();
        SpriteAni_03_Off();
        
       SpriteAni_04_Off();
       SpriteAni_05_Off();
       SpriteAni_06_Off();

       SpriteAni_07_Off();
       SpriteAni_08_Off();
       SpriteAni_09_Off();

       SpriteAni_10_Off();
       SpriteAni_11_Off();
       SpriteAni_12_Off();
       
    }


    //==========================================================
    //==========================================================
    public void SpriteAni_01_On()
    {
        UI_Sprite_Ani_01[0].enabled = true;
        UI_Sprite_Ani_01[1].enabled = true;
        UI_Sprite_Ani_01[2].enabled = true;
        UI_Sprite_Ani_01[3].enabled = true;
        UI_Sprite_Ani_01[4].enabled = true;
        UI_Sprite_Ani_01[5].enabled = true;
        UI_Sprite_Ani_01[6].enabled = true;
    }

    public void SpriteAni_01_Off()
    {
        UI_Sprite_Ani_01[0].enabled = false;
        UI_Sprite_Ani_01[1].enabled = false;
        UI_Sprite_Ani_01[2].enabled = false;
        UI_Sprite_Ani_01[3].enabled = false;
        UI_Sprite_Ani_01[4].enabled = false;
        UI_Sprite_Ani_01[5].enabled = false;
        UI_Sprite_Ani_01[6].enabled = false;
    }
    //==========================================================
    //==========================================================
    public void SpriteAni_02_On()
    {
        UI_Sprite_Ani_02[0].enabled = true;
        UI_Sprite_Ani_02[1].enabled = true;
        UI_Sprite_Ani_02[2].enabled = true;
        UI_Sprite_Ani_02[3].enabled = true;
        UI_Sprite_Ani_02[4].enabled = true;
        UI_Sprite_Ani_02[5].enabled = true;
        UI_Sprite_Ani_02[6].enabled = true;
    }

    public void SpriteAni_02_Off()
    {
        UI_Sprite_Ani_02[0].enabled = false;
        UI_Sprite_Ani_02[1].enabled = false;
        UI_Sprite_Ani_02[2].enabled = false;
        UI_Sprite_Ani_02[3].enabled = false;
        UI_Sprite_Ani_02[4].enabled = false;
        UI_Sprite_Ani_02[5].enabled = false;
        UI_Sprite_Ani_02[6].enabled = false;
    }
    //==========================================================
    //==========================================================
    public void SpriteAni_03_On()
    {
        UI_Sprite_Ani_03[0].enabled = true;
        UI_Sprite_Ani_03[1].enabled = true;
        UI_Sprite_Ani_03[2].enabled = true;
        UI_Sprite_Ani_03[3].enabled = true;
        UI_Sprite_Ani_03[4].enabled = true;
        UI_Sprite_Ani_03[5].enabled = true;
        UI_Sprite_Ani_03[6].enabled = true;
    }

    public void SpriteAni_03_Off()
    {
        UI_Sprite_Ani_03[0].enabled = false;
        UI_Sprite_Ani_03[1].enabled = false;
        UI_Sprite_Ani_03[2].enabled = false;
        UI_Sprite_Ani_03[3].enabled = false;
        UI_Sprite_Ani_03[4].enabled = false;
        UI_Sprite_Ani_03[5].enabled = false;
        UI_Sprite_Ani_03[6].enabled = false;
    }
    //==========================================================
    //==========================================================
    public void SpriteAni_04_On()
    {
        UI_Sprite_Ani_04[0].enabled = true;
        UI_Sprite_Ani_04[1].enabled = true;
        UI_Sprite_Ani_04[2].enabled = true;
        UI_Sprite_Ani_04[3].enabled = true;
        UI_Sprite_Ani_04[4].enabled = true;
        UI_Sprite_Ani_04[5].enabled = true;
        UI_Sprite_Ani_04[6].enabled = true;
    }

    public void SpriteAni_04_Off()
    {
        UI_Sprite_Ani_04[0].enabled = false;
        UI_Sprite_Ani_04[1].enabled = false;
        UI_Sprite_Ani_04[2].enabled = false;
        UI_Sprite_Ani_04[3].enabled = false;
        UI_Sprite_Ani_04[4].enabled = false;
        UI_Sprite_Ani_04[5].enabled = false;
        UI_Sprite_Ani_04[6].enabled = false;
    }
    //==========================================================
    //==========================================================
    public void SpriteAni_05_On()
    {
        UI_Sprite_Ani_05[0].enabled = true;
        UI_Sprite_Ani_05[1].enabled = true;
        UI_Sprite_Ani_05[2].enabled = true;
        UI_Sprite_Ani_05[3].enabled = true;
        UI_Sprite_Ani_05[4].enabled = true;
        UI_Sprite_Ani_05[5].enabled = true;
        UI_Sprite_Ani_05[6].enabled = true;
    }

    public void SpriteAni_05_Off()
    {
        UI_Sprite_Ani_05[0].enabled = false;
        UI_Sprite_Ani_05[1].enabled = false;
        UI_Sprite_Ani_05[2].enabled = false;
        UI_Sprite_Ani_05[3].enabled = false;
        UI_Sprite_Ani_05[4].enabled = false;
        UI_Sprite_Ani_05[5].enabled = false;
        UI_Sprite_Ani_05[6].enabled = false;
    }
    //==========================================================
    //==========================================================
    public void SpriteAni_06_On()
    {
        UI_Sprite_Ani_06[0].enabled = true;
        UI_Sprite_Ani_06[1].enabled = true;
        UI_Sprite_Ani_06[2].enabled = true;
        UI_Sprite_Ani_06[3].enabled = true;
        UI_Sprite_Ani_06[4].enabled = true;
        UI_Sprite_Ani_06[5].enabled = true;
        UI_Sprite_Ani_06[6].enabled = true;
    }

    public void SpriteAni_06_Off()
    {
        UI_Sprite_Ani_06[0].enabled = false;
        UI_Sprite_Ani_06[1].enabled = false;
        UI_Sprite_Ani_06[2].enabled = false;
        UI_Sprite_Ani_06[3].enabled = false;
        UI_Sprite_Ani_06[4].enabled = false;
        UI_Sprite_Ani_06[5].enabled = false;
        UI_Sprite_Ani_06[6].enabled = false;
    }
    //==========================================================
    //==========================================================
    public void SpriteAni_07_On()
    {
        UI_Sprite_Ani_07[0].enabled = true;
        UI_Sprite_Ani_07[1].enabled = true;
        UI_Sprite_Ani_07[2].enabled = true;
        UI_Sprite_Ani_07[3].enabled = true;
        UI_Sprite_Ani_07[4].enabled = true;
        UI_Sprite_Ani_07[5].enabled = true;
        UI_Sprite_Ani_07[6].enabled = true;
    }

    public void SpriteAni_07_Off()
    {
        UI_Sprite_Ani_07[0].enabled = false;
        UI_Sprite_Ani_07[1].enabled = false;
        UI_Sprite_Ani_07[2].enabled = false;
        UI_Sprite_Ani_07[3].enabled = false;
        UI_Sprite_Ani_07[4].enabled = false;
        UI_Sprite_Ani_07[5].enabled = false;
        UI_Sprite_Ani_07[6].enabled = false;
    }
    //==========================================================
    //==========================================================
    public void SpriteAni_08_On()
    {
        UI_Sprite_Ani_08[0].enabled = true;
        UI_Sprite_Ani_08[1].enabled = true;
        UI_Sprite_Ani_08[2].enabled = true;
        UI_Sprite_Ani_08[3].enabled = true;
        UI_Sprite_Ani_08[4].enabled = true;
        UI_Sprite_Ani_08[5].enabled = true;
        UI_Sprite_Ani_08[6].enabled = true;
    }

    public void SpriteAni_08_Off()
    {
        UI_Sprite_Ani_08[0].enabled = false;
        UI_Sprite_Ani_08[1].enabled = false;
        UI_Sprite_Ani_08[2].enabled = false;
        UI_Sprite_Ani_08[3].enabled = false;
        UI_Sprite_Ani_08[4].enabled = false;
        UI_Sprite_Ani_08[5].enabled = false;
        UI_Sprite_Ani_08[6].enabled = false;
    }
    //==========================================================
    //==========================================================
    public void SpriteAni_09_On()
    {
        UI_Sprite_Ani_09[0].enabled = true;
        UI_Sprite_Ani_09[1].enabled = true;
        UI_Sprite_Ani_09[2].enabled = true;
        UI_Sprite_Ani_09[3].enabled = true;
        UI_Sprite_Ani_09[4].enabled = true;
        UI_Sprite_Ani_09[5].enabled = true;
        UI_Sprite_Ani_09[6].enabled = true;
    }

    public void SpriteAni_09_Off()
    {
        UI_Sprite_Ani_09[0].enabled = false;
        UI_Sprite_Ani_09[1].enabled = false;
        UI_Sprite_Ani_09[2].enabled = false;
        UI_Sprite_Ani_09[3].enabled = false;
        UI_Sprite_Ani_09[4].enabled = false;
        UI_Sprite_Ani_09[5].enabled = false;
        UI_Sprite_Ani_09[6].enabled = false;
    }
    //==========================================================
    //==========================================================
    public void SpriteAni_10_On()
    {
        UI_Sprite_Ani_10[0].enabled = true;
        UI_Sprite_Ani_10[1].enabled = true;
        UI_Sprite_Ani_10[2].enabled = true;
        UI_Sprite_Ani_10[3].enabled = true;
        UI_Sprite_Ani_10[4].enabled = true;
        UI_Sprite_Ani_10[5].enabled = true;
        UI_Sprite_Ani_10[6].enabled = true;
    }

    public void SpriteAni_10_Off()
    {
        UI_Sprite_Ani_10[0].enabled = false;
        UI_Sprite_Ani_10[1].enabled = false;
        UI_Sprite_Ani_10[2].enabled = false;
        UI_Sprite_Ani_10[3].enabled = false;
        UI_Sprite_Ani_10[4].enabled = false;
        UI_Sprite_Ani_10[5].enabled = false;
        UI_Sprite_Ani_10[6].enabled = false;
    }
    //==========================================================
    //==========================================================
    public void SpriteAni_11_On()
    {
        UI_Sprite_Ani_11[0].enabled = true;
        UI_Sprite_Ani_11[1].enabled = true;
        UI_Sprite_Ani_11[2].enabled = true;
        UI_Sprite_Ani_11[3].enabled = true;
        UI_Sprite_Ani_11[4].enabled = true;
        UI_Sprite_Ani_11[5].enabled = true;
        UI_Sprite_Ani_11[6].enabled = true;
    }

    public void SpriteAni_11_Off()
    {
        UI_Sprite_Ani_11[0].enabled = false;
        UI_Sprite_Ani_11[1].enabled = false;
        UI_Sprite_Ani_11[2].enabled = false;
        UI_Sprite_Ani_11[3].enabled = false;
        UI_Sprite_Ani_11[4].enabled = false;
        UI_Sprite_Ani_11[5].enabled = false;
        UI_Sprite_Ani_11[6].enabled = false;
    }
    //==========================================================
    //==========================================================
    public void SpriteAni_12_On()
    {
        UI_Sprite_Ani_12[0].enabled = true;
        UI_Sprite_Ani_12[1].enabled = true;
        UI_Sprite_Ani_12[2].enabled = true;
        UI_Sprite_Ani_12[3].enabled = true;
        UI_Sprite_Ani_12[4].enabled = true;
        UI_Sprite_Ani_12[5].enabled = true;
        UI_Sprite_Ani_12[6].enabled = true;
    }

    public void SpriteAni_12_Off()
    {
        UI_Sprite_Ani_12[0].enabled = false;
        UI_Sprite_Ani_12[1].enabled = false;
        UI_Sprite_Ani_12[2].enabled = false;
        UI_Sprite_Ani_12[3].enabled = false;
        UI_Sprite_Ani_12[4].enabled = false;
        UI_Sprite_Ani_12[5].enabled = false;
        UI_Sprite_Ani_12[6].enabled = false;
    }
    //==========================================================
    //==========================================================
}
