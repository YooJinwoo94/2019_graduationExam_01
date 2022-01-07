using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doing_Bar_05_00 : MonoBehaviour {

    public UIPanel Doing_Bar_Panel;
    public UISprite Doing_Bar_Sprite;

    public Grow_Up_Button_Cha_05_01 button_01;
    public Grow_Up_Button_Cha_05_02 button_02;
    public Grow_Up_Button_Cha_05_03 button_03;
    public Grow_Up_Button_Cha_05_04 button_04;

    public bool Is_Button_01;
    public bool Is_Button_02;
    public bool Is_Button_03;
    public bool Is_Button_04;

    public Cha_Grow_Up_05 _Grow_Up_Script;

    public Sound_Manager Sound_Man_Script;






    public void Start()
    {
        //행동 게이지바 0으로 초기화 
        Doing_Sprite_IS_Zero();

        Is_Button_01 = false;
        Is_Button_02 = false;
        Is_Button_03 = false;
        Is_Button_04 = false;
    }



    //행동 게이지바 0으로 초기화 
    public void Doing_Sprite_IS_Zero()
    {
        Doing_Bar_Sprite.fillAmount = 0f;
    }



    public void Doing_Sprite_Fill_Up()
    {
        StartCoroutine("Sprite_Fill_Up");
    }



    public void Doing_Bar_Panel_On()
    {
        StartCoroutine("Panel_On");
    }

    public void Doing_Bar_Panel_Off()
    {
        StartCoroutine("Panel_Off");
    }






    IEnumerator Sprite_Fill_Up()
    {
        if (Doing_Bar_Sprite.fillAmount == 1f)
        {
            Sound_Man_Script.Play_Box_End_Doing_Bar_05();

            Doing_Bar_Panel_Off();
            Doing_Sprite_IS_Zero();

            if (Is_Button_01 == true)
            {
                Debug.Log("Loading_Bar");
                button_01.Button_01_Staus();
            }

            else if (Is_Button_02 == true)
            {
                button_02.Button_02_Staus();
            }

            else if (Is_Button_03 == true)
            {
                button_03.Button_03_Staus();
            }

            else if (Is_Button_04 == true)
            {
                button_04.Button_04_Staus();
            }

            Is_Button_01 = false;
            Is_Button_02 = false;
            Is_Button_03 = false;
            Is_Button_04 = false;

            _Grow_Up_Script.Cha_Collider.enabled = true;

            yield break;
        }

        yield return new WaitForSeconds(0.1f);

        Doing_Bar_Sprite.fillAmount += 0.02f;
        StartCoroutine("Sprite_Fill_Up");
    }




    IEnumerator Panel_On()
    {
        if (Doing_Bar_Panel.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Doing_Bar_Panel.alpha += 1f;

        StartCoroutine("Panel_On");
    }

    IEnumerator Panel_Off()
    {
        if (Doing_Bar_Panel.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Doing_Bar_Panel.alpha -= 1f;

        StartCoroutine("Panel_Off");
    }
}
