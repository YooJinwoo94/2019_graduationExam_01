using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow_Up_Button_04 : MonoBehaviour
{
    public Cha_Grow_Up _Grow_Up_Script;
    public UIButton _Button_04;
    public UISprite Happy_Bar_Sprite;
    public UISprite Stress_Bar_Sprite;

    public Grow_Up_Button_01 _Grow_Up_Button_01_Script;
    public Grow_Up_Button_02 _Grow_Up_Button_02_Script;
    public Grow_Up_Button_03 _Grow_Up_Button_03_Script;

    public Doing_Bar Doing_Bar_Script;
    public Sound_Manager Sound_Man_Script;

    public UIPanel Angry_Panel;

    public Check_Cha_Type Check_Cha_Type_Ani;

    float Like = 0.4f;
    float Dis_Like = 0.4f;
    float Normal = 0.2f;

    private void Start()
    {
        // 일단 해당 스프라이트 안보이게 한다.
        Happy_Bar_Sprite.fillAmount = 0f;
        Stress_Bar_Sprite.fillAmount = 0f;
    }



    // 선호도 표 
    /*

 // 양상추

      타입A   01 버튼 = 좋음
              02 버튼 = 보통
              03 버튼 = 싫음 
              04 버튼 = 수면

 // 토마토

      타입B   01 버튼 = 보통
              02 버튼 = 좋음
              03 버튼 = 싫음 
              04 버튼 = 수면

 //양파

      타입C   01 버튼 = 싫음
              02 버튼 = 보통
              03 버튼 = 좋음 
              04 버튼 = 수면

 //고기

      타입D   01 버튼 = 보통 
              02 버튼 = 싫음
              03 버튼 = 좋음 
              04 버튼 = 수면

 //치킨

       타입E  01 버튼 = 좋음 
              02 버튼 = 보통
              03 버튼 = 싫음 
              04 버튼 = 수면

 //오징어 

      타입F   01 버튼 = 보통
              02 버튼 = 좋음
              03 버튼 = 싫음 
              04 버튼 = 수면

 //새우

       타입G  01 버튼 = 좋음 
              02 버튼 = 싫음
              03 버튼 = 보통 
              04 버튼 = 수면

 //생선

      타입H   01 버튼 = 싫음 
              02 버튼 = 좋음
              03 버튼 = 보통 
              04 버튼 = 수면

 //오일 

      타입I   01 버튼 = 보통 
              02 버튼 = 싫음
              03 버튼 = 좋음 
              04 버튼 = 수면

 //조미료

      타입J   01 버튼 = 좋음 
              02 버튼 = 싫음
              03 버튼 = 보통 
              04 버튼 = 수면
     */






    ///////////////////////////////////////////////////////////////// 잠자기 
    // 캐릭터의 종류/ 성장정도 에 따라 애니메이션 변화 
    public void Check_Cha_And_Change_Ani()
    {
        _Grow_Up_Script.Chage();
    }



    public void Check_Is_Count_Down_For_Trash_Cha()
    {
        if (_Grow_Up_Script.Cha_Stress_Bar_Float >= 1f)
        {
            _Grow_Up_Script.Count_Down();
        }
    }



    // 해당 _04버튼 클릭 
    public void Button_04()
    {
        Debug.Log("숙면 타임");

        Check_Cha_Type_Ani.Sleep_Ani();

        _Grow_Up_Script.Con_Grow_Button = true;

        // 내가 보냈어! 
        Doing_Bar_Script.Is_Button_04 = true;

        // 행동바의 모습이 보인다.
        Doing_Bar_Script.Doing_Bar_Panel_On();

        // 행동바의 게이지가 차오른다.
        Doing_Bar_Script.Doing_Sprite_Fill_Up();

        // 버튼의 모습이 보이지 않는다.
        _Grow_Up_Script.Cant_See_Grow_Button();

        // 캐릭터의 콜라이더를 끈다.
        _Grow_Up_Script.Cha_Collider.enabled = false;

        // 앵그리 상태 안보이게 하기
        Angry_Panel.alpha = 0f;

        Sound_Man_Script.Play_Button_Click();
        Sound_Man_Script.Play_Sleep_01();
        Sound_Man_Script.Stop_Box_Loop_Sound_01();
    }


    // doing_bar_끝나고 호출
    //게이지 바 이미지 체인지용 
    public void Button_04_Staus()
    {
        Sound_Man_Script.Stop_Sleep_01();

        _Grow_Up_Script.Cha_Stress_Count = 0;


        Check_Is_Count_Down_For_Trash_Cha();
        Check_Cha_And_Change_Ani(); ;
    }
}
