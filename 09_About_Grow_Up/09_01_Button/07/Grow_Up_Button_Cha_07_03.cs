using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow_Up_Button_Cha_07_03 : MonoBehaviour {

    public Cha_Grow_Up_07 _Grow_Up_Script;
    public UIButton _Button_03;
    public UISprite Happy_Bar_Sprite;
    public UISprite Stress_Bar_Sprite;

    public Doing_Bar_07_00 Doing_Bar_Script;

    public UIPanel Angry_Panel;

    public Particle_Manager Particle_Man_Script;
    public Sound_Manager Sound_Man_Script;

    private int i = 6;

    public Check_Cha_Type_07 Check_Cha_Type_Ani;

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



    // 행복도가 0 이하로 떨어지지 않도록 하기 
    public void Check_If_Count_Is_Zero()
    {
        if (_Grow_Up_Script.Cha_Happy_Bar_Float <= 0f)
        {
            _Grow_Up_Script.Cha_Happy_Bar_Float = 0f;
        }
        if (_Grow_Up_Script.Cha_Stress_Bar_Float <= 0f)
        {
            _Grow_Up_Script.Cha_Stress_Bar_Float = 0f;
        }
    }



    // 해당 _03버튼 클릭 
    public void Button_03()
    {
        Check_Cha_Type_Ani.Exercise_Ani();

        _Grow_Up_Script.Con_Grow_Button = true;

        // 캐릭터의 콜라이더를 끈다.
        _Grow_Up_Script.Cha_Collider.enabled = false;

        // 버튼의 모습이 보이지 않는다.
        _Grow_Up_Script.Cant_See_Grow_Button();

        // 내가 보냈어!
        Doing_Bar_Script.Is_Button_03 = true;

        // 행동바의 모습이 보인다.
        Doing_Bar_Script.Doing_Bar_Panel_On();

        // 행동바의 게이지가 차오른다.
        Doing_Bar_Script.Doing_Sprite_Fill_Up();

        Sound_Man_Script.Play_Button_Click();
        Sound_Man_Script.Play_Exercise_07();
        Sound_Man_Script.Stop_Box_Loop_Sound_07();
    }



    public void Button_03_Staus()
    {
        Sound_Man_Script.Stop_Exercise_07();

        if (_Grow_Up_Script.Cha_Stress_Count >= 2)
        {
            // 앵그리 상태 보이게 하기
            Angry_Panel.alpha = 1f;
        }

        //
        //버튼 클릭을 3번하면 스트레스 상태입니다.
        //

        if (_Grow_Up_Script.Cha_Stress_Count >= 2)
        {

            // 양상추
            // 만약 해당 아이의 타입이 A라면
            if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_A)
            {
                Debug.Log("싫음");

                _Grow_Up_Script.Cha_Stress_Bar_Float += 0.2f;


                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //토마토
            // 만약 해당 아이의 타입이 B라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_B)
            {
                Debug.Log("싫음");

                _Grow_Up_Script.Cha_Stress_Bar_Float += 0.2f;

                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //양파
            // 만약 해당 아이의 타입이 C라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_C)
            {
                Debug.Log("좋음");

                _Grow_Up_Script.Cha_Happy_Bar_Float += 0.2f;

                StartCoroutine("Happy_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //고기
            // 만약 해당 아이의 타입이 D라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_D)
            {
                Debug.Log("좋음");

                _Grow_Up_Script.Cha_Happy_Bar_Float += 0.2f;

                StartCoroutine("Happy_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //치킨
            // 만약 해당 아이의 타입이 E라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_E)
            {
                Debug.Log("싫음");

                _Grow_Up_Script.Cha_Stress_Bar_Float += 0.2f;

                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //오징어
            // 만약 해당 아이의 타입이 F라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_F)
            {
                Debug.Log("싫음");

                _Grow_Up_Script.Cha_Stress_Bar_Float += 0.2f;

                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //새우
            // 만약 해당 아이의 타입이 G라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_G)
            {
                Debug.Log("보통");

                _Grow_Up_Script.Cha_Happy_Bar_Float += 0.1f;
                _Grow_Up_Script.Cha_Stress_Bar_Float += 0.1f;

                StartCoroutine("Happy_Bar_Up_Down");
                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //생선
            // 만약 해당 아이의 타입이 H라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_H)
            {
                Debug.Log("보통");

                _Grow_Up_Script.Cha_Happy_Bar_Float += 0.1f;
                _Grow_Up_Script.Cha_Stress_Bar_Float += 0.1f;

                StartCoroutine("Happy_Bar_Up_Down");
                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //오일
            // 만약 해당 아이의 타입이 I라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_I)
            {
                Debug.Log("좋음");

                _Grow_Up_Script.Cha_Happy_Bar_Float += 0.2f;

                StartCoroutine("Happy_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //조미료
            // 만약 해당 아이의 타입이 J라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_J)
            {
                Debug.Log("보통");

                _Grow_Up_Script.Cha_Happy_Bar_Float += 0.1f;
                _Grow_Up_Script.Cha_Stress_Bar_Float += 0.1f;

                StartCoroutine("Happy_Bar_Up_Down");
                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }





            // 스트레스 카운트가 3 초과일 경우 스트레스 상황 발생
            // 스트레스 카운트 증가 
            _Grow_Up_Script.Cha_Stress_Count++;
        }

        //
        // 정상 상태
        //

        else if (_Grow_Up_Script.Cha_Stress_Count <= 1)
        {
            // 양상추
            // 만약 해당 아이의 타입이 A라면
            if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_A)
            {
                Debug.Log("싫음");
                Particle_Man_Script.Do_Not_Like[i].Play(true);

                _Grow_Up_Script.Cha_Stress_Bar_Float += Dis_Like;


                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //토마토
            // 만약 해당 아이의 타입이 B라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_B)
            {
                Debug.Log("싫음");
                Particle_Man_Script.Do_Not_Like[i].Play(true);

                _Grow_Up_Script.Cha_Stress_Bar_Float += Dis_Like;

                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //양파
            // 만약 해당 아이의 타입이 C라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_C)
            {
                Debug.Log("좋음");

                Particle_Man_Script.Hard_Love[i].Play(true);


                _Grow_Up_Script.Cha_Happy_Bar_Float += Like;

                StartCoroutine("Happy_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //고기
            // 만약 해당 아이의 타입이 D라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_D)
            {
                Debug.Log("좋음");

                Particle_Man_Script.Hard_Love[i].Play(true);

                _Grow_Up_Script.Cha_Happy_Bar_Float += Like;

                StartCoroutine("Happy_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //치킨
            // 만약 해당 아이의 타입이 E라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_E)
            {
                Debug.Log("싫음");

                Particle_Man_Script.Do_Not_Like[i].Play(true);

                _Grow_Up_Script.Cha_Stress_Bar_Float += Dis_Like;

                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //오징어
            // 만약 해당 아이의 타입이 F라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_F)
            {
                Debug.Log("싫음");

                Particle_Man_Script.Do_Not_Like[i].Play(true);

                _Grow_Up_Script.Cha_Stress_Bar_Float += Dis_Like;

                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //새우
            // 만약 해당 아이의 타입이 G라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_G)
            {
                Debug.Log("보통");

                // 보통 파티클
                Particle_Man_Script.Normal_Heart[i].Play(true);

                _Grow_Up_Script.Cha_Happy_Bar_Float += Normal;
                _Grow_Up_Script.Cha_Stress_Bar_Float += Normal;

                StartCoroutine("Happy_Bar_Up_Down");
                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //생선
            // 만약 해당 아이의 타입이 H라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_H)
            {
                Debug.Log("보통");

                // 보통 파티클
                Particle_Man_Script.Normal_Heart[i].Play(true);

                _Grow_Up_Script.Cha_Happy_Bar_Float += Normal;
                _Grow_Up_Script.Cha_Stress_Bar_Float += Normal;

                StartCoroutine("Happy_Bar_Up_Down");
                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //오일
            // 만약 해당 아이의 타입이 I라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_I)
            {
                Debug.Log("좋음");

                // 매우 좋아함 파티클 
                Particle_Man_Script.Hard_Love[i].Play(true);

                _Grow_Up_Script.Cha_Happy_Bar_Float += Like;

                StartCoroutine("Happy_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }

            //조미료
            // 만약 해당 아이의 타입이 J라면
            else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_J)
            {
                Debug.Log("보통");

                // 보통 파티클
                Particle_Man_Script.Normal_Heart[i].Play(true);

                _Grow_Up_Script.Cha_Happy_Bar_Float += Normal;
                _Grow_Up_Script.Cha_Stress_Bar_Float += Normal;

                StartCoroutine("Happy_Bar_Up_Down");
                StartCoroutine("Stress_Bar_Up_Down");

                Check_If_Count_Is_Zero();
            }




            // 스트레스 카운트 증가 
            // 스트레스 카운트가 3 초과일 경우 스트레스 상황 발생 
            _Grow_Up_Script.Cha_Stress_Count++;
        }


        Check_Is_Count_Down_For_Trash_Cha();
        Check_Cha_And_Change_Ani();
    }




    IEnumerator Happy_Bar_Up_Down()
    {
        if (Happy_Bar_Sprite.fillAmount >= _Grow_Up_Script.Cha_Happy_Bar_Float)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.01f);

        Happy_Bar_Sprite.fillAmount += 0.01f;
        StartCoroutine("Happy_Bar_Up_Down");
    }

    IEnumerator Stress_Bar_Up_Down()
    {
        if (Stress_Bar_Sprite.fillAmount >= _Grow_Up_Script.Cha_Stress_Bar_Float)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.01f);

        Stress_Bar_Sprite.fillAmount += 0.01f;
        StartCoroutine("Stress_Bar_Up_Down");
    }
}
