using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock_Manager : MonoBehaviour {

  //  public Transform Clock_Pin;

    public UISprite Timer_Spot;

    bool Double_Check;

    public UILabel A;
    public UILabel AA;
    public UILabel AAA;

    public static int Time_Flow_Counter;

    int a = 4;
    int aa = 59;
    int aaa = 60;

    public static int Time_Flow_Counter_aaa = 0 ;
    private int x = 0;

    public End_Scene_Manager End_Scene_Man_Script;
    public Fail_Scene_Manager Fail_Scene_Man_Script;
    public Player_Happy_Manager Player_Happy_Man_Script;





    private void Awake()
    {
       // StartCoroutine("Time_Flow_Clock");
        StartCoroutine("Real_Time");
        StartCoroutine("Panel_On_Off");
    }

    IEnumerator Real_Time()
    {  
        if (Time_Flow_Counter_aaa >= 59)
        {
            Time_Flow_Counter_aaa = 0;
            aaa = 59;
            aa--;
            AA.text = aa.ToString();

            if (aa <= 0)
            {
                aa = 59;
                AA.text = aa.ToString();

                a--;
                A.text = a.ToString();

                if(a <=-1)
                {
                    x = System.Convert.ToInt32(Player_Happy_Man_Script.Player_Happy_Count.text);
                    if (x < 19)
                    {
                        Fail_Scene_Man_Script.Pop_Up_Fail_Scene();
                    }
                    else
                    {
                        End_Scene_Man_Script.Pop_Up_End_Scene();
                    }
              
       

                    A.text = "0";
                    AA.text = "00";
                    AAA.text = "00";
                    yield break;
                }
            }
        }
        Time_Flow_Counter_aaa++;
        aaa--;
        AAA.text = aaa.ToString();

        yield return new WaitForSeconds(0.001f);

        StartCoroutine("Real_Time");
    }





    IEnumerator Panel_On_Off()
    {
       if (Double_Check == false)
        {
            Double_Check = true;
            Timer_Spot.spriteName = "Timer_Spot";
        
        }

       else if (Double_Check == true)
        {
            Double_Check = false;
            Timer_Spot.spriteName = "None";
        }
        yield return new WaitForSeconds(0.5f);

        StartCoroutine("Panel_On_Off");
    }





    /*
    IEnumerator Time_Flow_Clock()
    {
        if (Time_Flow_Counter ==180)
        {
            Time_Flow_Counter = 0;
           // Vector3 Next_Angle_01 = Clock_Pin.localEulerAngles;
         //   Next_Angle_01.z = 0;
            BG_Image_Sprite.fillAmount = 1f;
            /////////////////////////////////////////// 초기화 시작데스 
            End_Scene_Man_Script.Pop_Up_End_Scene();

            yield break;
        }

       // Vector3 Next_Angle = Clock_Pin.localEulerAngles;
        BG_Image_Sprite.fillAmount -= 0.00555f;
        //Next_Angle.z = -2f;
       // Clock_Pin.Rotate(Next_Angle);
        Time_Flow_Counter++;


        yield return new WaitForSeconds(1f);

        StartCoroutine("Time_Flow_Clock");
    }
    */
}
