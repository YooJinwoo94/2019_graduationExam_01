using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Sound_Manager : MonoBehaviour {

    public Cha_Grow_Up Cha_Grow_Up_01;
    public Cha_Grow_Up_02 Cha_Grow_Up_02;
    public Cha_Grow_Up_03 Cha_Grow_Up_03;
    public Cha_Grow_Up_04 Cha_Grow_Up_04;
    public Cha_Grow_Up_05 Cha_Grow_Up_05;
    public Cha_Grow_Up_06 Cha_Grow_Up_06;
    public Cha_Grow_Up_07 Cha_Grow_Up_07;
    public Cha_Grow_Up_08 Cha_Grow_Up_08;
    public Cha_Grow_Up_09 Cha_Grow_Up_09;
    public Cha_Grow_Up_10 Cha_Grow_Up_10;
    public Cha_Grow_Up_11 Cha_Grow_Up_11;
    public Cha_Grow_Up_12 Cha_Grow_Up_12;

    public Camera Cam;

    public UISlider Option_Sound_Slider;
 
    // ============================================================== 중복 안되는 애들 처리 
    public AudioSource[] Normal_bgm_Not_Dubble_Audio_Source;
    public AudioClip[] Normal_bgm_Not_Dubble_AudioClip;
    // ============================================================== 중복 안되는 애들 처리 

        // Box_Ani  // 밥  샤워 운동 잠 
    // ============================================================== 중복  애들 처리 
    public AudioSource[] Room_bgm_While_Ani_On_Audio_Source_01;
    public AudioClip[] Room_bgm_While_Ani_On_AudioClip_01;

    public AudioSource[] Room_bgm_While_Ani_On_Audio_Source_02;
    public AudioClip[] Room_bgm_While_Ani_On_AudioClip_02;

    public AudioSource[] Room_bgm_While_Ani_On_Audio_Source_03;
    public AudioClip[] Room_bgm_While_Ani_On_AudioClip_03;

    public AudioSource[] Room_bgm_While_Ani_On_Audio_Source_04;
    public AudioClip[] Room_bgm_While_Ani_On_AudioClip_04;

    public AudioSource[] Room_bgm_While_Ani_On_Audio_Source_05;
    public AudioClip[] Room_bgm_While_Ani_On_AudioClip_05;

    public AudioSource[] Room_bgm_While_Ani_On_Audio_Source_06;
    public AudioClip[] Room_bgm_While_Ani_On_AudioClip_06;

    public AudioSource[] Room_bgm_While_Ani_On_Audio_Source_07;
    public AudioClip[] Room_bgm_While_Ani_On_AudioClip_07;

    public AudioSource[] Room_bgm_While_Ani_On_Audio_Source_08;
    public AudioClip[] Room_bgm_While_Ani_On_AudioClip_08;

    public AudioSource[] Room_bgm_While_Ani_On_Audio_Source_09;
    public AudioClip[] Room_bgm_While_Ani_On_AudioClip_09;

    public AudioSource[] Room_bgm_While_Ani_On_Audio_Source_10;
    public AudioClip[] Room_bgm_While_Ani_On_AudioClip_10;

    public AudioSource[] Room_bgm_While_Ani_On_Audio_Source_11;
    public AudioClip[] Room_bgm_While_Ani_On_AudioClip_11;

    public AudioSource[] Room_bgm_While_Ani_On_Audio_Source_12;
    public AudioClip[] Room_bgm_While_Ani_On_AudioClip_12;

    //================================================================= 냉동고 처리 
    public AudioSource[] Frige_bgm_While_Ani_On_Audio_Source;
    public AudioClip[] Frige_bgm_While_Ani_On_AudioClip;


    //================================================================= 짧은 음 반복 처리 
    public AudioSource[] Cha_Idle_Audio_Source;
    public AudioClip[] Cha_Idle_AudioClip;

    // ============================================================== 중복  애들 처리 
    public AudioMixer _AudioMixer;

    public Transform Cam_Pos;

    public bool Check_is_Bgm_Main;

    public bool Floor_1;
    public bool Floor_2;
    public bool Floor_3;
    public bool Floor_4;
    public bool Frige_;

    public bool Is_Debuff_Sound;

    public bool Turn_Off_01;
    public bool Turn_Off_02;
    public bool Turn_Off_03;
    public bool Turn_Off_04;
    public bool Turn_Off_05;
    public bool Turn_Off_06;
    public bool Turn_Off_07;
    public bool Turn_Off_08;
    public bool Turn_Off_09;
    public bool Turn_Off_10;
    public bool Turn_Off_11;
    public bool Turn_Off_12;

    public bool Turn_Off_BGM_Sound;

    int Count_Box_Sound = 12;





    private void Awake()
    {
      
        for (int i =0; i< 12; i++)
        {
            Cha_Idle_Audio_Source[i] = gameObject.AddComponent<AudioSource>();
            Cha_Idle_Audio_Source[i].playOnAwake = false;
        }

        for (int i = 0; i < 4; i++)
        {
            Frige_bgm_While_Ani_On_Audio_Source[i] = gameObject.AddComponent<AudioSource>();
            Frige_bgm_While_Ani_On_Audio_Source[i].playOnAwake = false;

            Frige_bgm_While_Ani_On_Audio_Source[i].clip = Frige_bgm_While_Ani_On_AudioClip[i];
        }                           // 냉동 게이지 진행 상태 

        for (int i =0; i <15; i ++)
        {
            Normal_bgm_Not_Dubble_Audio_Source[i] = gameObject.AddComponent<AudioSource>();
            Normal_bgm_Not_Dubble_Audio_Source[i].playOnAwake = false;

            Normal_bgm_Not_Dubble_Audio_Source[i].clip = Normal_bgm_Not_Dubble_AudioClip[i];
        }                           // 공통 음 


        //01
        for (int i = 0; i < Count_Box_Sound; i++)
        {
           Room_bgm_While_Ani_On_Audio_Source_01[i] = gameObject.AddComponent<AudioSource>();
           Room_bgm_While_Ani_On_Audio_Source_01[i].playOnAwake = false;

           Room_bgm_While_Ani_On_Audio_Source_01[i].clip = Room_bgm_While_Ani_On_AudioClip_01[i];
        }
        //02
        for (int i = 0; i < Count_Box_Sound; i++)
        {
            Room_bgm_While_Ani_On_Audio_Source_02[i] = gameObject.AddComponent<AudioSource>();
            Room_bgm_While_Ani_On_Audio_Source_02[i].playOnAwake = false;

            Room_bgm_While_Ani_On_Audio_Source_02[i].clip = Room_bgm_While_Ani_On_AudioClip_02[i];
        }
        //03
        for (int i = 0; i < Count_Box_Sound; i++)
        {
            Room_bgm_While_Ani_On_Audio_Source_03[i] = gameObject.AddComponent<AudioSource>();
            Room_bgm_While_Ani_On_Audio_Source_03[i].playOnAwake = false;
        
            Room_bgm_While_Ani_On_Audio_Source_03[i].clip = Room_bgm_While_Ani_On_AudioClip_03[i];
        }
        //04
        for (int i = 0; i < Count_Box_Sound; i++)
        {
            Room_bgm_While_Ani_On_Audio_Source_04[i] = gameObject.AddComponent<AudioSource>();
            Room_bgm_While_Ani_On_Audio_Source_04[i].playOnAwake = false;

            Room_bgm_While_Ani_On_Audio_Source_04[i].clip = Room_bgm_While_Ani_On_AudioClip_04[i];
        }
        //05
        for (int i = 0; i < Count_Box_Sound; i++)
        {
            Room_bgm_While_Ani_On_Audio_Source_05[i] = gameObject.AddComponent<AudioSource>();
            Room_bgm_While_Ani_On_Audio_Source_05[i].playOnAwake = false;

            Room_bgm_While_Ani_On_Audio_Source_05[i].clip = Room_bgm_While_Ani_On_AudioClip_05[i];
        }
        //06
        for (int i = 0; i < Count_Box_Sound; i++)
        {
            Room_bgm_While_Ani_On_Audio_Source_06[i] = gameObject.AddComponent<AudioSource>();
            Room_bgm_While_Ani_On_Audio_Source_06[i].playOnAwake = false;

            Room_bgm_While_Ani_On_Audio_Source_06[i].clip = Room_bgm_While_Ani_On_AudioClip_06[i];
        }
        //07
        for (int i = 0; i < Count_Box_Sound; i++)
        {
            Room_bgm_While_Ani_On_Audio_Source_07[i] = gameObject.AddComponent<AudioSource>();
            Room_bgm_While_Ani_On_Audio_Source_07[i].playOnAwake = false;

            Room_bgm_While_Ani_On_Audio_Source_07[i].clip = Room_bgm_While_Ani_On_AudioClip_07[i];
        }
        //08
        for (int i = 0; i < Count_Box_Sound; i++)
        {
            Room_bgm_While_Ani_On_Audio_Source_08[i] = gameObject.AddComponent<AudioSource>();
            Room_bgm_While_Ani_On_Audio_Source_08[i].playOnAwake = false;

            Room_bgm_While_Ani_On_Audio_Source_08[i].clip = Room_bgm_While_Ani_On_AudioClip_08[i];
        }
        //09
        for (int i = 0; i < Count_Box_Sound; i++)
        {
            Room_bgm_While_Ani_On_Audio_Source_09[i] = gameObject.AddComponent<AudioSource>();
            Room_bgm_While_Ani_On_Audio_Source_09[i].playOnAwake = false;
        
            Room_bgm_While_Ani_On_Audio_Source_09[i].clip = Room_bgm_While_Ani_On_AudioClip_09[i];
        }                //IDLE 상태
        //10
        for (int i = 0; i < Count_Box_Sound; i++)
        {
            Room_bgm_While_Ani_On_Audio_Source_10[i] = gameObject.AddComponent<AudioSource>();
            Room_bgm_While_Ani_On_Audio_Source_10[i].playOnAwake = false;

            Room_bgm_While_Ani_On_Audio_Source_10[i].clip = Room_bgm_While_Ani_On_AudioClip_10[i];
        }                //피로 상태
        //11
        for (int i = 0; i < Count_Box_Sound; i++)
        {
            Room_bgm_While_Ani_On_Audio_Source_11[i] = gameObject.AddComponent<AudioSource>();
            Room_bgm_While_Ani_On_Audio_Source_11[i].playOnAwake = false;

            Room_bgm_While_Ani_On_Audio_Source_11[i].clip = Room_bgm_While_Ani_On_AudioClip_11[i];
        }                //상함 상태
        //12                                                        
        for (int i = 0; i < Count_Box_Sound; i++)
        {
            Room_bgm_While_Ani_On_Audio_Source_12[i] = gameObject.AddComponent<AudioSource>();
            Room_bgm_While_Ani_On_Audio_Source_12[i].playOnAwake = false;

            Room_bgm_While_Ani_On_Audio_Source_12[i].clip = Room_bgm_While_Ani_On_AudioClip_12[i];
        }              

        Floor_1 = true;
        Floor_2 = false;
        Floor_3 = false;
        Floor_4 = false;
        Frige_ = false;

        Check_is_Bgm_Main = true;


        StartCoroutine("Check_Is_If_Cam_Is_On_Frigerator");
        // 카메라 층마다 다른 사운드 조절 
        StartCoroutine("Check_Cam_Pos");     
    }




    IEnumerator Check_Is_If_Cam_Is_On_Frigerator()
    {
        Vector3 pos = Cam_Pos.localPosition;

        if (Turn_Off_BGM_Sound == false)
        {
            if (Is_Debuff_Sound == false)
            {
                if (pos.y >= -2200 && Check_is_Bgm_Main == true)
                {
                    Check_is_Bgm_Main = false;
                    Stop_bgm_Frige_Main();
                    Play_bgm_Basic_Main();
                }
                else if (pos.y <= -2250 && Check_is_Bgm_Main == false)
                {
                    Check_is_Bgm_Main = true;
                    Stop_bgm_Basic_Main();
                    Play_bgm_Frige_Main();
                }
            }
        }
     
        yield return new WaitForSeconds(0.2f);
        StartCoroutine("Check_Is_If_Cam_Is_On_Frigerator");
    }

    IEnumerator Check_Cam_Pos()
    {
        Vector3 pos = Cam_Pos.localPosition;

        if (Cam.orthographicSize >= 1)
        {
            //1층이네? 
            if (pos.y >= -280)
            {
                Floor_1 = true;
                Floor_2 = false;
                Floor_3 = false;
                Floor_4 = false;
                Frige_ = false;
            }
            //2층이네? 
            if (pos.y <= -290 && pos.y >= -763)
            {
                Floor_1 = false;
                Floor_2 = true;
                Floor_3 = false;
                Floor_4 = false;
                Frige_ = false;
            }
            //3층이네? 
            if (pos.y <= -770 && pos.y >= -1275)
            {
                Floor_1 = false;
                Floor_2 = false;
                Floor_3 = true;
                Floor_4 = false;
                Frige_ = false;
            }
            //4층이네? 
            if (pos.y <= -1280 && pos.y >= -1904)
            {
                Floor_1 = false;
                Floor_2 = false;
                Floor_3 = false;
                Floor_4 = true;
                Frige_ = false;
            }
            //냉동실이네?
            if (pos.y <= -2323 && pos.y >= -2993)
            {
                Floor_1 = false;
                Floor_2 = false;
                Floor_3 = false;
                Floor_4 = false;
                Frige_ = true;
            }


            if (Floor_1 == true)
            {
                //1 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_01[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_02[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_03[i].volume = 0.4f;
                  
                }
                for (int i = 0; i < 3; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.4f;
                }          
                //2 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_04[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_05[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_06[i].volume = 0.2f;                  
                }
                for (int i = 3; i < 6; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.2f;
                }
                //3 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_07[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_08[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_09[i].volume = 0f;                
                }
                for (int i = 6; i < 9; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //4 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_10[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_11[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_12[i].volume = 0f;                
                }
                for (int i = 9; i < 12; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                // 냉동층
                for (int i = 0; i < 4; i++)
                {                   
                    Frige_bgm_While_Ani_On_Audio_Source[i].volume = 0f;
                }
            }
            else if (Floor_2 == true)
            {
                //1 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_01[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_02[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_03[i].volume = 0.2f;
                }
                for (int i = 0; i < 3; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.2f;
                }
                //2 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_04[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_05[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_06[i].volume = 0.4f;
                }
                for (int i = 3; i < 6; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.4f;
                }
                //3 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_07[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_08[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_09[i].volume = 0.2f;
                }
                for (int i = 6; i < 9; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.2f;
                }
                //4 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_10[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_11[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_12[i].volume = 0f;
                }
                for (int i = 9; i < 12; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                // 냉동층
                for (int i = 0; i < 4; i++)
                {
                    Frige_bgm_While_Ani_On_Audio_Source[i].volume = 0f;
                }
            }
            else if (Floor_3 == true)
            {
                //1 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_01[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_02[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_03[i].volume = 0f;
                }
                for (int i = 0; i < 3; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //2 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_04[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_05[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_06[i].volume = 0.2f;
                }
                for (int i = 3; i < 6; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.2f;
                }
                //3 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_07[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_08[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_09[i].volume = 0.4f;
                }
                for (int i = 6; i < 9; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.4f;
                }
                //4 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_10[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_11[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_12[i].volume = 0.2f;
                }
                for (int i = 9; i < 12; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.2f;
                }
                // 냉동층
                for (int i = 0; i < 4; i++)
                {
                    Frige_bgm_While_Ani_On_Audio_Source[i].volume = 0f;
                }
            }
            else if (Floor_4 == true)
            {
                //1 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_01[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_02[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_03[i].volume = 0f;
                }
                for (int i = 0; i < 3; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //2 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_04[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_05[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_06[i].volume = 0f;
                }
                for (int i = 3; i < 6; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //3 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_07[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_08[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_09[i].volume = 0.2f;
                }
                for (int i = 6; i < 9; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.2f;
                }
                //4 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_10[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_11[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_12[i].volume = 0.4f;
                }
                for (int i = 9; i < 12; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.4f;
                }
                // 냉동층
                for (int i = 0; i < 4; i++)
                {
                    Frige_bgm_While_Ani_On_Audio_Source[i].volume = 0.2f;
                }
            }
            else if (Frige_ == true)
            {
                //1 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_01[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_02[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_03[i].volume = 0f;
                }
                for (int i = 0; i < 3; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //2 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_04[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_05[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_06[i].volume = 0f;
                }
                for (int i = 3; i < 6; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //3 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_07[i].volume = 0f; 
                    Room_bgm_While_Ani_On_Audio_Source_08[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_09[i].volume = 0f;
                }
                for (int i = 6; i < 9; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //4 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_10[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_11[i].volume = 0.2f;
                    Room_bgm_While_Ani_On_Audio_Source_12[i].volume = 0.2f;
                }
                for (int i = 9; i < 12; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.2f;
                }
                // 냉동층
                for (int i = 0; i < 4; i++)
                {
                    Frige_bgm_While_Ani_On_Audio_Source[i].volume = 0.4f;
                }
            }
        }
        else if (Cam.orthographicSize < 1)
        {
            //1층이네? 
            if (pos.y >= -280)
            {
                Floor_1 = true;
                Floor_2 = false;
                Floor_3 = false;
                Floor_4 = false;
                Frige_ = false;
            }
            //2층이네? 
            if (pos.y <= -290 && pos.y >= -763)
            {
                Floor_1 = false;
                Floor_2 = true;
                Floor_3 = false;
                Floor_4 = false;
                Frige_ = false;
            }
            //3층이네? 
            if (pos.y <= -770 && pos.y >= -1275)
            {
                Floor_1 = false;
                Floor_2 = false;
                Floor_3 = true;
                Floor_4 = false;
                Frige_ = false;
            }
            //4층이네? 
            if (pos.y <= -1280 && pos.y >= -1904)
            {
                Floor_1 = false;
                Floor_2 = false;
                Floor_3 = false;
                Floor_4 = true;
                Frige_ = false;
            }
            //냉동실이네?
            if (pos.y <= -2323 && pos.y >= -2993)
            {
                Floor_1 = false;
                Floor_2 = false;
                Floor_3 = false;
                Floor_4 = false;
                Frige_ = true;
            }



            if (Floor_1 == true)
            {
                //1 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_01[i].volume = 0.8f;
                    Room_bgm_While_Ani_On_Audio_Source_02[i].volume = 0.8f;
                    Room_bgm_While_Ani_On_Audio_Source_03[i].volume = 0.8f;
                }
                for (int i = 0; i < 3; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.8f;
                }
                //2 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_04[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_05[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_06[i].volume = 0.4f;
                }
                for (int i = 3; i < 6; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.4f;
                }
                //3 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_07[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_08[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_09[i].volume = 0f;
                }
                for (int i = 6; i < 9; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //4 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_10[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_11[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_12[i].volume = 0f;
                }
                for (int i = 9; i < 12; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                // 냉동층
                for (int i = 0; i < 4; i++)
                {
                    Frige_bgm_While_Ani_On_Audio_Source[i].volume = 0f;
                }
            }
            else if (Floor_2 == true)
            {
                //1 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_01[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_02[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_03[i].volume = 0.4f;
                }
                for (int i = 0; i < 3; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.4f;
                }
                //2 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_04[i].volume = 0.8f;
                    Room_bgm_While_Ani_On_Audio_Source_05[i].volume = 0.8f;
                    Room_bgm_While_Ani_On_Audio_Source_06[i].volume = 0.8f;
                }
                for (int i = 3; i < 6; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.8f;
                }
                //3 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_07[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_08[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_09[i].volume = 0.4f;
                }
                for (int i = 6; i < 9; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.4f;
                }
                //4 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_10[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_11[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_12[i].volume = 0f;
                }
                for (int i = 9; i < 12; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                // 냉동층
                for (int i = 0; i < 4; i++)
                {
                    Frige_bgm_While_Ani_On_Audio_Source[i].volume = 0f;
                }
            }
            else if (Floor_3 == true)
            {
                //1 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_01[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_02[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_03[i].volume = 0f;
                }
                for (int i = 0; i < 3; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //2 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_04[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_05[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_06[i].volume = 0.4f;
                }
                for (int i = 3; i < 6; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.4f;
                }
                //3 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_07[i].volume = 0.8f;
                    Room_bgm_While_Ani_On_Audio_Source_08[i].volume = 0.8f;
                    Room_bgm_While_Ani_On_Audio_Source_09[i].volume = 0.8f;
                }
                for (int i = 6; i < 9; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.8f;
                }
                //4 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_10[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_11[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_12[i].volume = 0.4f;
                }
                for (int i = 9; i < 12; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.4f;
                }
                // 냉동층
                for (int i = 0; i < 4; i++)
                {
                    Frige_bgm_While_Ani_On_Audio_Source[i].volume = 0f;
                }
            }
            else if (Floor_4 == true)
            {
                //1 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_01[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_02[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_03[i].volume = 0f;
                }
                for (int i = 0; i < 3; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //2 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_04[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_05[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_06[i].volume = 0f;
                }
                for (int i = 3; i < 6; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //3 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_07[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_08[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_09[i].volume = 0.4f;
                }
                for (int i = 6; i < 9; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.4f;
                }
                //4 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_10[i].volume = 0.8f;
                    Room_bgm_While_Ani_On_Audio_Source_11[i].volume = 0.8f;
                    Room_bgm_While_Ani_On_Audio_Source_12[i].volume = 0.8f;
                }
                for (int i = 9; i < 12; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.8f;
                }
                // 냉동층
                for (int i = 0; i < 4; i++)
                {
                    Frige_bgm_While_Ani_On_Audio_Source[i].volume = 0.4f;
                }
            }
            else if (Frige_ == true)
            {
                //1 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_01[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_02[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_03[i].volume = 0f;
                }
                for (int i = 0; i < 3; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //2 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_04[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_05[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_06[i].volume = 0f;
                }
                for (int i = 3; i < 6; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //3 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_07[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_08[i].volume = 0f;
                    Room_bgm_While_Ani_On_Audio_Source_09[i].volume = 0f;
                }
                for (int i = 6; i < 9; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0f;
                }
                //4 층 음악 조절 
                for (int i = 0; i < Count_Box_Sound; i++)
                {
                    Room_bgm_While_Ani_On_Audio_Source_10[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_11[i].volume = 0.4f;
                    Room_bgm_While_Ani_On_Audio_Source_12[i].volume = 0.4f;
                }
                for (int i = 9; i < 12; i++)
                {
                    Cha_Idle_Audio_Source[i].volume = 0.4f;
                }
                // 냉동층
                for (int i = 0; i < 4; i++)
                {
                    Frige_bgm_While_Ani_On_Audio_Source[i].volume = 0.8f;
                }
            }
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine("Check_Cam_Pos");
    }







    public void Con_All_Sound()
    {
        for (int i = 0; i < 10; i++)
        {
            Normal_bgm_Not_Dubble_Audio_Source[i].volume = Option_Sound_Slider.value / 3;
        } 
        /*
       for (int i = 0; i < Count_Box_Sound; i++)
        {
            Room_bgm_While_Ani_On_Audio_Source_01[i].volume = Option_Sound_Slider.value / 3;
            Room_bgm_While_Ani_On_Audio_Source_02[i].volume = Option_Sound_Slider.value / 3;
            Room_bgm_While_Ani_On_Audio_Source_03[i].volume = Option_Sound_Slider.value / 3;
            Room_bgm_While_Ani_On_Audio_Source_04[i].volume = Option_Sound_Slider.value / 3;
            Room_bgm_While_Ani_On_Audio_Source_05[i].volume = Option_Sound_Slider.value / 3;
            Room_bgm_While_Ani_On_Audio_Source_06[i].volume = Option_Sound_Slider.value / 3;

            Room_bgm_While_Ani_On_Audio_Source_07[i].volume = Option_Sound_Slider.value / 3;
            Room_bgm_While_Ani_On_Audio_Source_08[i].volume = Option_Sound_Slider.value / 3;
            Room_bgm_While_Ani_On_Audio_Source_09[i].volume = Option_Sound_Slider.value / 3;
            Room_bgm_While_Ani_On_Audio_Source_10[i].volume = Option_Sound_Slider.value / 3;
            Room_bgm_While_Ani_On_Audio_Source_11[i].volume = Option_Sound_Slider.value / 3;
            Room_bgm_While_Ani_On_Audio_Source_12[i].volume = Option_Sound_Slider.value / 3;
        }
        for (int i = 0; i < 4; i++)
        {
            Frige_bgm_While_Ani_On_Audio_Source[i].volume = Option_Sound_Slider.value / 3;
        }
        for (int i = 0; i < 12; i++)
        {
            Cha_Idle_Audio_Source[i].volume = Option_Sound_Slider.value / 3;
        }
        */
    }

    /*
    0 = bgm_Basic_Main                      // LOOP
    1 = bgm_Frige_Main                      // LOOP
    2 = bgm_Escape_Sound                   // LOOP
    3 = bgm_Delivery_Sound
    4 = bgm_Stage_Clear
    5 = Button_Click
    6 = Scene_Change 
    7 = Cha_Buy || Room_Buy 
    8 = Room_Click
    9 = Order_Time_Coming
    */
    // ============================================================== 중복 안되는 애들 처리 
    // ============================================================== 중복 안되는 애들 처리 
    //================================================== Play
    
    public void Play_bgm_Basic_Main()
    {
        Normal_bgm_Not_Dubble_Audio_Source[0].loop = true;
        Normal_bgm_Not_Dubble_Audio_Source[0].Play();
    }
    //========================================================================== 냉동고 BG
    public void Play_bgm_Frige_Main()
    {
        Normal_bgm_Not_Dubble_Audio_Source[1].loop = true;
        Normal_bgm_Not_Dubble_Audio_Source[1].Play();
    }   
    //========================================================================== 냉동고에서 탈출 했을때 
    public void Play_Escape_Sound()
    {
        if(Is_Debuff_Sound == false)
        {
            Is_Debuff_Sound = true;

            Stop_bgm_Basic_Main();
            Stop_bgm_Frige_Main();

            Normal_bgm_Not_Dubble_Audio_Source[2].loop = true;
            Normal_bgm_Not_Dubble_Audio_Source[2].Play();
        }
    }
    //========================================================================== 납품 성공시 
    public void Play_Delivery_Sound()
    {
        Normal_bgm_Not_Dubble_Audio_Source[3].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[3].Play();
    }
    //========================================================================== 스테이지 클리어시 
    public void Play_Stage_Clear()
    {
        Stop_bgm_Basic_Main();
        Stop_bgm_Frige_Main();
        Stop_Escape_Sound();
        Normal_bgm_Not_Dubble_Audio_Source[4].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[4].Play();
    }
    //========================================================================== 버튼 클릭시 
    public void Play_Button_Click()
    {
        Normal_bgm_Not_Dubble_Audio_Source[5].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[5].Play();
    }
    //========================================================================== 새로운 씬이 나오면 발동 
    public void Play_Scene_Change()
    {
        Normal_bgm_Not_Dubble_Audio_Source[6].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[6].Play();
    }
    //========================================================================== 방/ 캐릭터 구입시 
    public void Play_Cha_Buy_Room_Buy()
    {
        Normal_bgm_Not_Dubble_Audio_Source[7].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[7].Play();
    }
    //========================================================================== 방클릭시 
    public void Play_Room_Click()
    {
        Normal_bgm_Not_Dubble_Audio_Source[8].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[8].Play();
    }
    //========================================================================== 제한 시간이 다가올때 
    public void Play_Order_Time_Coming()
    {
        Normal_bgm_Not_Dubble_Audio_Source[9].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[9].Play();
    }
    //========================================================================== 수확할떄
    public void Play_Get_Food_Put_To_Inven()
    {
        Normal_bgm_Not_Dubble_Audio_Source[10].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[10].Play();
    }
    //========================================================================== 납품 실패시
    public void Play_Delivery_Fail_Sound()
    {
        Normal_bgm_Not_Dubble_Audio_Source[11].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[11].Play();
    }
    //========================================================================== 알람창 뜨면 
    public void Play_Alarm_Sound()
    {
        Normal_bgm_Not_Dubble_Audio_Source[12].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[12].Play();
    }
    //================================================== 
    //================================================== 
    //================================================== 
    //================================================== 
    //================================================== 
    //================================================== 
    //================================================== 
    //================================================== 
    //================================================== Stop
    public void Stop_bgm_Basic_Main()
    {
        Normal_bgm_Not_Dubble_Audio_Source[0].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[0].Stop();
    }
    public void Stop_bgm_Frige_Main()
    {
        Normal_bgm_Not_Dubble_Audio_Source[1].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[1].Stop();
    }
    public void Stop_Escape_Sound()
    {
        Normal_bgm_Not_Dubble_Audio_Source[2].loop = false;
        Normal_bgm_Not_Dubble_Audio_Source[2].Stop();

        Vector3 pos = Cam_Pos.localPosition;

        if (pos.y >= -2200)
        {
            Check_is_Bgm_Main = true;
        }
        else
        {
            Check_is_Bgm_Main = false;
        }
    }
    // ============================================================== 중복 안되는 애들 처리 
    // ============================================================== 중복 안되는 애들 처리 






 

    //============================================================================================================================= 0
    // 음식 먹기 
    public void Play_Food_Eat_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[0].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_01[0].Play();
    }
    public void Play_Food_Eat_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[0].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_02[0].Play();
    }
    public void Play_Food_Eat_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[0].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_03[0].Play();
    }
    //================================================== 
    public void Play_Food_Eat_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[0].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_04[0].Play();
    }
    public void Play_Food_Eat_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[0].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_05[0].Play();
    }
    public void Play_Food_Eat_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[0].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_06[0].Play();
    }
    //================================================== 
    public void Play_Food_Eat_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[0].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_07[0].Play();
    }
    public void Play_Food_Eat_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[0].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_08[0].Play();
    }
    public void Play_Food_Eat_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[0].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_09[0].Play();
    }
    //================================================== 
    public void Play_Food_Eat_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[0].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_10[0].Play();
    }
    public void Play_Food_Eat_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[0].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_11[0].Play();
    }
    public void Play_Food_Eat_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[0].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_12[0].Play();
    }

    //============================================================================================ Stop

    public void Stop_Food_Eat_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[0].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_01[0].Stop();
    }
    public void Stop_Food_Eat_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[0].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_02[0].Stop();
    }
    public void Stop_Food_Eat_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[0].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_03[0].Stop();
    }
    //================================================== 
    public void Stop_Food_Eat_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[0].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_04[0].Stop();
    }
    public void Stop_Food_Eat_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[0].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_05[0].Stop();
    }
    public void Stop_Food_Eat_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[0].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_06[0].Stop();
    }
    //================================================== 
    public void Stop_Food_Eat_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[0].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_07[0].Stop();
    }
    public void Stop_Food_Eat_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[0].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_08[0].Stop();
    }
    public void Stop_Food_Eat_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[0].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_09[0].Stop();
    }
    //================================================== 
    public void Stop_Food_Eat_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[0].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_10[0].Stop();
    }
    public void Stop_Food_Eat_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[0].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_11[0].Stop();
    }
    public void Stop_Food_Eat_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[0].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_12[0].Stop();
    }




    //============================================================================================================================= 1
    // 샤워 하기 
    public void Play_Shower_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[1].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_01[1].Play();
    }
    public void Play_Shower_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[1].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_02[1].Play();
    }
    public void Play_Shower_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[1].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_03[1].Play();
    }
    //================================================== 
    public void Play_Shower_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[1].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_04[1].Play();
    }
    public void Play_Shower_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[1].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_05[1].Play();
    }
    public void Play_Shower_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[1].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_06[1].Play();
    }
    //================================================== 
    public void Play_Shower_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[1].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_07[1].Play();
    }
    public void Play_Shower_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[1].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_08[1].Play();
    }
    public void Play_Shower_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[1].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_09[1].Play();
    }
    //================================================== 
    public void Play_Shower_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[1].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_10[1].Play();
    }
    public void Play_Shower_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[1].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_11[1].Play();
    }
    public void Play_Shower_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[1].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_12[1].Play();
    }

    //============================================================================================ Stop

    public void Stop_Shower_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[1].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_01[1].Stop();
    }
    public void Stop_Shower_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[1].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_02[1].Stop();
    }
    public void Stop_Shower_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[1].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_03[1].Stop();
    }
    //================================================== 
    public void Stop_Shower_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[1].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_04[1].Stop();
    }
    public void Stop_Shower_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[1].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_05[1].Stop();
    }
    public void Stop_Shower_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[1].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_06[1].Stop();
    }
    //================================================== 
    public void Stop_Shower_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[1].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_07[1].Stop();
    }
    public void Stop_Shower_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[1].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_08[1].Stop();
    }
    public void Stop_Shower_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[1].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_09[1].Stop();
    }
    //================================================== 
    public void Stop_Shower_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[1].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_10[1].Stop();
    }
    public void Stop_Shower_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[1].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_11[1].Stop();
    }
    public void Stop_Shower_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[1].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_12[1].Stop();
    }




    //============================================================================================================================= 2
    // 운동하기 
    public void Play_Exercise_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[2].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_01[2].Play();
    }
    public void Play_Exercise_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[2].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_02[2].Play();
    }
    public void Play_Exercise_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[2].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_03[2].Play();
    }
    //================================================== 
    public void Play_Exercise_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[2].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_04[2].Play();
    }
    public void Play_Exercise_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[2].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_05[2].Play();
    }
    public void Play_Exercise_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[2].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_06[2].Play();
    }
    //================================================== 
    public void Play_Exercise_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[2].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_07[2].Play();
    }
    public void Play_Exercise_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[2].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_08[2].Play();
    }
    public void Play_Exercise_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[2].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_09[2].Play();
    }
    //================================================== 
    public void Play_Exercise_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[2].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_10[2].Play();
    }
    public void Play_Exercise_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[2].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_11[2].Play();
    }
    public void Play_Exercise_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[2].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_12[2].Play();
    }

    //============================================================================================ Stop

    public void Stop_Exercise_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[2].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_01[2].Stop();
    }
    public void Stop_Exercise_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[2].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_02[2].Stop();
    }
    public void Stop_Exercise_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[2].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_03[2].Stop();
    }
    //================================================== 
    public void Stop_Exercise_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[2].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_04[2].Stop();
    }
    public void Stop_Exercise_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[2].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_05[2].Stop();
    }
    public void Stop_Exercise_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[2].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_06[2].Stop();
    }
    //================================================== 
    public void Stop_Exercise_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[2].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_07[2].Stop();
    }
    public void Stop_Exercise_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[2].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_08[2].Stop();
    }
    public void Stop_Exercise_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[2].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_09[2].Stop();
    }
    //================================================== 
    public void Stop_Exercise_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[2].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_10[2].Stop();
    }
    public void Stop_Exercise_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[2].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_11[2].Stop();
    }
    public void Stop_Exercise_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[2].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_12[2].Stop();
    }




    //============================================================================================================================= 3
    // 잠자기 
    public void Play_Sleep_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[3].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_01[3].Play();
    }
    public void Play_Sleep_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[3].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_02[3].Play();
    }
    public void Play_Sleep_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[3].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_03[3].Play();
    }
    //================================================== 
    public void Play_Sleep_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[3].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_04[3].Play();
    }
    public void Play_Sleep_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[3].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_05[3].Play();
    }
    public void Play_Sleep_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[3].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_06[3].Play();
    }
    //================================================== 
    public void Play_Sleep_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[3].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_07[3].Play();
    }
    public void Play_Sleep_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[3].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_08[3].Play();
    }
    public void Play_Sleep_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[3].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_09[3].Play();
    }
    //================================================== 
    public void Play_Sleep_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[3].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_10[3].Play();
    }
    public void Play_Sleep_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[3].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_11[3].Play();
    }
    public void Play_Sleep_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[3].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_12[3].Play();
    }

    //============================================================================================ Stop

    public void Stop_Sleep_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[3].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_01[3].Stop();
    }
    public void Stop_Sleep_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[3].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_02[3].Stop();
    }
    public void Stop_Sleep_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[3].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_03[3].Stop();
    }
    //================================================== 
    public void Stop_Sleep_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[3].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_04[3].Stop();
    }
    public void Stop_Sleep_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[3].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_05[3].Stop();
    }
    public void Stop_Sleep_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[3].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_06[3].Stop();
    }
    //================================================== 
    public void Stop_Sleep_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[3].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_07[3].Stop();
    }
    public void Stop_Sleep_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[3].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_08[3].Stop();
    }
    public void Stop_Sleep_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[3].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_09[3].Stop();
    }
    //================================================== 
    public void Stop_Sleep_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[3].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_10[3].Stop();
    }
    public void Stop_Sleep_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[3].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_11[3].Stop();
    }
    public void Stop_Sleep_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[3].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_12[3].Stop();
    }



    /*
    //============================================================================================================================= 4
    // 피로 상태인 경우 
    public void Play_Tired_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[4].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_01[4].Play();
    }
    public void Play_Tired_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[4].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_02[4].Play();
    }
    public void Play_Tired_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[4].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_03[4].Play();
    }
    //================================================== 
    public void Play_Tired_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[4].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_04[4].Play();
    }
    public void Play_Tired_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[4].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_05[4].Play();
    }
    public void Play_Tired_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[4].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_06[4].Play();
    }
    //================================================== 
    public void Play_Tired_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[4].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_07[4].Play();
    }
    public void Play_Tired_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[4].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_08[4].Play();
    }
    public void Play_Tired_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[4].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_09[4].Play();
    }
    //================================================== 
    public void Play_Tired_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[4].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_10[4].Play();
    }
    public void Play_Tired_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[4].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_11[4].Play();
    }
    public void Play_Tired_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[4].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_12[4].Play();
    }

    //============================================================================================ Stop

    public void Stop_Tired_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[4].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_01[4].Stop();
    }
    public void Stop_Tired_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[4].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_02[4].Stop();
    }
    public void Stop_Tired_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[4].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_03[4].Stop();
    }
    //================================================== 
    public void Stop_Tired_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[4].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_04[4].Stop();
    }
    public void Stop_Tired_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[4].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_05[4].Stop();
    }
    public void Stop_Tired_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[4].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_06[4].Stop();
    }
    //================================================== 
    public void Stop_Tired_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[4].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_07[4].Stop();
    }
    public void Stop_Tired_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[4].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_08[4].Stop();
    }
    public void Stop_Tired_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[4].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_09[4].Stop();
    }
    //================================================== 
    public void Stop_Tired_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[4].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_10[4].Stop();
    }
    public void Stop_Tired_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[4].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_11[4].Stop();
    }
    public void Stop_Tired_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[4].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_12[4].Stop();
    }
    */



    //============================================================================================================================= 5
    // 상한 상태인 경우 
    public void Play_Box_Cha_IS_Trash_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[5].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_01[5].Play();
    }
    public void Play_Box_Cha_IS_Trash_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[5].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_02[5].Play();
    }
    public void Play_Box_Cha_IS_Trash_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[5].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_03[5].Play();
    }
    //================================================== 
    public void Play_Box_Cha_IS_Trash_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[5].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_04[5].Play();
    }
    public void Play_Box_Cha_IS_Trash_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[5].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_05[5].Play();
    }
    public void Play_Box_Cha_IS_Trash_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[5].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_06[5].Play();
    }
    //================================================== 
    public void Play_Box_Cha_IS_Trash_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[5].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_07[5].Play();
    }
    public void Play_Box_Cha_IS_Trash_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[5].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_08[5].Play();
    }
    public void Play_Box_Cha_IS_Trash_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[5].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_09[5].Play();
    }
    //================================================== 
    public void Play_Box_Cha_IS_Trash_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[5].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_10[5].Play();
    }
    public void Play_Box_Cha_IS_Trash_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[5].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_11[5].Play();
    }
    public void Play_Box_Cha_IS_Trash_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[5].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_12[5].Play();
    }



    //============================================================================================================================= 6
    // 진화 상태인 경우
    public void Play_Evo_Cha_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[6].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_01[6].Play();
    }
    public void Play_Evo_Cha_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[6].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_02[6].Play();
    }
    public void Play_Evo_Cha_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[6].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_03[6].Play();
    }
    //================================================== 
    public void Play_Evo_Cha_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[6].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_04[6].Play();
    }
    public void Play_Evo_Cha_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[6].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_05[6].Play();
    }
    public void Play_Evo_Cha_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[6].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_06[6].Play();
    }
    //================================================== 
    public void Play_Evo_Cha_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[6].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_07[6].Play();
    }
    public void Play_Evo_Cha_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[6].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_08[6].Play();
    }
    public void Play_Evo_Cha_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[6].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_09[6].Play();
    }
    //================================================== 
    public void Play_Evo_Cha_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[6].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_10[6].Play();
    }
    public void Play_Evo_Cha_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[6].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_11[6].Play();
    }
    public void Play_Evo_Cha_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[6].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_12[6].Play();
    }




    //============================================================================================================================= 7
    // 행동바의 게이지가 full 인 경우 
    public void Play_Box_End_Doing_Bar_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[7].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_01[7].Play();
    }
    public void Play_Box_End_Doing_Bar_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[7].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_02[7].Play();
    }
    public void Play_Box_End_Doing_Bar_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[7].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_03[7].Play();
    }
    //================================================== 
    public void Play_Box_End_Doing_Bar_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[7].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_04[7].Play();
    }
    public void Play_Box_End_Doing_Bar_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[7].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_05[7].Play();
    }
    public void Play_Box_End_Doing_Bar_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[7].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_06[7].Play();
    }
    //================================================== 
    public void Play_Box_End_Doing_Bar_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[7].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_07[7].Play();
    }
    public void Play_Box_End_Doing_Bar_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[7].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_08[7].Play();
    }
    public void Play_Box_End_Doing_Bar_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[7].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_09[7].Play();
    }
    //================================================== 
    public void Play_Box_End_Doing_Bar_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[7].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_10[7].Play();
    }
    public void Play_Box_End_Doing_Bar_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[7].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_11[7].Play();
    }
    public void Play_Box_End_Doing_Bar_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[7].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_12[7].Play();
    }



    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //============================================================================================================================= 8
    // 방 아이의 상태가 idle 
    public void Loof_Play_Box_Cha_IS_Idle_01()
    {
      if ( Cha_Grow_Up_01.Cha_Stress_Count < 3 )
        {
            Turn_Off_01 = false;

            StartCoroutine("Box_Cha_Idle_01");

            Loof_Stop_Box_Cha_IS_Tired_01();
            Loof_Stop_Box_Cha_IS_Trash_01();
        } 
      else if (Cha_Grow_Up_01.Cha_Stress_Count >= 3)
        {
            Loof_Play_Box_Cha_IS_Tired_01();

            Loof_Stop_Box_Cha_IS_Idle_01();
            Loof_Stop_Box_Cha_IS_Trash_01();
        }
    }
    public void Loof_Play_Box_Cha_IS_Idle_02()
    {
        if (Cha_Grow_Up_02.Cha_Stress_Count < 3)
        {
            Turn_Off_02 = false;
            StartCoroutine("Box_Cha_Idle_02");

            Loof_Stop_Box_Cha_IS_Tired_02();
            Loof_Stop_Box_Cha_IS_Trash_02();
        }
        else if (Cha_Grow_Up_02.Cha_Stress_Count >= 3)
        {
            Loof_Play_Box_Cha_IS_Tired_02();

            Loof_Stop_Box_Cha_IS_Idle_02();
            Loof_Stop_Box_Cha_IS_Trash_02();
        }
    }
    public void Loof_Play_Box_Cha_IS_Idle_03()
    {
        if (Cha_Grow_Up_03.Cha_Stress_Count < 3)
        {
            Turn_Off_03 = false;
            StartCoroutine("Box_Cha_Idle_03");

            Loof_Stop_Box_Cha_IS_Tired_03();
            Loof_Stop_Box_Cha_IS_Trash_03();
        }
        else if (Cha_Grow_Up_03.Cha_Stress_Count >= 3)
        {
            Loof_Play_Box_Cha_IS_Tired_03();
            Debug.Log("aaa");
            Loof_Stop_Box_Cha_IS_Idle_03();
            Loof_Stop_Box_Cha_IS_Trash_03();
        }

    }
    //================================================== 
    public void Loof_Play_Box_Cha_IS_Idle_04()
    {
        if (Cha_Grow_Up_04.Cha_Stress_Count < 3)
        {
            Turn_Off_04 = false;
            StartCoroutine("Box_Cha_Idle_04");

            Loof_Stop_Box_Cha_IS_Tired_04();
            Loof_Stop_Box_Cha_IS_Trash_04();
        }
        else if (Cha_Grow_Up_04.Cha_Stress_Count >= 3)
        {
            Loof_Play_Box_Cha_IS_Tired_04();

            Loof_Stop_Box_Cha_IS_Idle_04();
            Loof_Stop_Box_Cha_IS_Trash_04();
        }
    }
    public void Loof_Play_Box_Cha_IS_Idle_05()
    {
        if (Cha_Grow_Up_05.Cha_Stress_Count < 3)
        {
            Turn_Off_05 = false;
            StartCoroutine("Box_Cha_Idle_05");

            Loof_Stop_Box_Cha_IS_Tired_05();
            Loof_Stop_Box_Cha_IS_Trash_05();
        }
        else if (Cha_Grow_Up_05.Cha_Stress_Count >= 3)
        {
            Loof_Play_Box_Cha_IS_Tired_05();

            Loof_Stop_Box_Cha_IS_Idle_05();
            Loof_Stop_Box_Cha_IS_Trash_05();
        }
    }
    public void Loof_Play_Box_Cha_IS_Idle_06()
    {
        if (Cha_Grow_Up_06.Cha_Stress_Count < 3)
        {
            Turn_Off_06 = false;
            StartCoroutine("Box_Cha_Idle_06");

            Loof_Stop_Box_Cha_IS_Tired_06();
            Loof_Stop_Box_Cha_IS_Trash_06();
        }
        else if (Cha_Grow_Up_06.Cha_Stress_Count >= 3)
        {
            Loof_Play_Box_Cha_IS_Tired_06();

            Loof_Stop_Box_Cha_IS_Idle_06();
            Loof_Stop_Box_Cha_IS_Trash_06();
        }
    }
    //================================================== 
    public void Loof_Play_Box_Cha_IS_Idle_07()
    {
        if (Cha_Grow_Up_07.Cha_Stress_Count < 3)
        {
            Turn_Off_07 = false;
            StartCoroutine("Box_Cha_Idle_07");

            Loof_Stop_Box_Cha_IS_Tired_07();
            Loof_Stop_Box_Cha_IS_Trash_07();
        }
        else if (Cha_Grow_Up_07.Cha_Stress_Count >= 3)
        {
            Loof_Play_Box_Cha_IS_Tired_07();

            Loof_Stop_Box_Cha_IS_Idle_07();
            Loof_Stop_Box_Cha_IS_Trash_07();
        }
    }
    public void Loof_Play_Box_Cha_IS_Idle_08()
    {
        if (Cha_Grow_Up_08.Cha_Stress_Count < 3)
        {
            Turn_Off_08 = false;
            StartCoroutine("Box_Cha_Idle_08");

            Loof_Stop_Box_Cha_IS_Tired_08();
            Loof_Stop_Box_Cha_IS_Trash_08();
        }
        else if (Cha_Grow_Up_08.Cha_Stress_Count >= 3)
        {
            Loof_Play_Box_Cha_IS_Tired_08();

            Loof_Stop_Box_Cha_IS_Idle_08();
            Loof_Stop_Box_Cha_IS_Trash_08();
        }
    }
    public void Loof_Play_Box_Cha_IS_Idle_09()
    {
        if (Cha_Grow_Up_09.Cha_Stress_Count < 3)
        {
            Turn_Off_09 = false;
            StartCoroutine("Box_Cha_Idle_09");

            Loof_Stop_Box_Cha_IS_Tired_09();
            Loof_Stop_Box_Cha_IS_Trash_09();
        }
        else if (Cha_Grow_Up_09.Cha_Stress_Count >= 3)
        {
            Loof_Play_Box_Cha_IS_Tired_09();

            Loof_Stop_Box_Cha_IS_Idle_09();
            Loof_Stop_Box_Cha_IS_Trash_09();
        }
    }
    //================================================== 
    public void Loof_Play_Box_Cha_IS_Idle_10()
    {
        if (Cha_Grow_Up_10.Cha_Stress_Count < 3)
        {
            Turn_Off_10 = false;
            StartCoroutine("Box_Cha_Idle_10");

            Loof_Stop_Box_Cha_IS_Tired_10();
            Loof_Stop_Box_Cha_IS_Trash_10();
        }
        else if (Cha_Grow_Up_10.Cha_Stress_Count >= 3)
        {
            Loof_Play_Box_Cha_IS_Tired_10();

            Loof_Stop_Box_Cha_IS_Idle_10();
            Loof_Stop_Box_Cha_IS_Trash_10();
        }
    }
    public void Loof_Play_Box_Cha_IS_Idle_11()
    {
        if (Cha_Grow_Up_11.Cha_Stress_Count < 3)
        {
            Turn_Off_11 = false;
            StartCoroutine("Box_Cha_Idle_11");

            Loof_Stop_Box_Cha_IS_Tired_11();
            Loof_Stop_Box_Cha_IS_Trash_11();
        }
        else if (Cha_Grow_Up_11.Cha_Stress_Count >= 3)
        {
            Loof_Play_Box_Cha_IS_Tired_11();

            Loof_Stop_Box_Cha_IS_Idle_11();
            Loof_Stop_Box_Cha_IS_Trash_11();
        }
    }
    public void Loof_Play_Box_Cha_IS_Idle_12()
    {
        if (Cha_Grow_Up_12.Cha_Stress_Count < 3)
        {
            Turn_Off_12 = false;
            StartCoroutine("Box_Cha_Idle_12");

            Loof_Stop_Box_Cha_IS_Tired_12();
            Loof_Stop_Box_Cha_IS_Trash_12();
        }
        else if (Cha_Grow_Up_12.Cha_Stress_Count >= 3)
        {
            Loof_Play_Box_Cha_IS_Tired_12();

            Loof_Stop_Box_Cha_IS_Idle_12();
            Loof_Stop_Box_Cha_IS_Trash_12();
        }
    }

    //============================================================================================ Stop

    public void Loof_Stop_Box_Cha_IS_Idle_01()
    {
        Turn_Off_01 = true;
        StopCoroutine("Box_Cha_Idle_01");
    }
    public void Loof_Stop_Box_Cha_IS_Idle_02()
    {
        Turn_Off_02 = true;
        StopCoroutine("Box_Cha_Idle_02");
    }
    public void Loof_Stop_Box_Cha_IS_Idle_03()
    {
        Turn_Off_03 = true;
        StopCoroutine("Box_Cha_Idle_03");
    }
    //================================================== 
    public void Loof_Stop_Box_Cha_IS_Idle_04()
    {
        Turn_Off_04 = true;
        StopCoroutine("Box_Cha_Idle_04");
    }
    public void Loof_Stop_Box_Cha_IS_Idle_05()
    {
        Turn_Off_05 = true;
        StopCoroutine("Box_Cha_Idle_05");
    }
    public void Loof_Stop_Box_Cha_IS_Idle_06()
    {
        Turn_Off_06 = true;
        StopCoroutine("Box_Cha_Idle_06");
    }
    //================================================== 
    public void Loof_Stop_Box_Cha_IS_Idle_07()
    {
        Turn_Off_07 = true;
        StopCoroutine("Box_Cha_Idle_07");
    }
    public void Loof_Stop_Box_Cha_IS_Idle_08()
    {
        Turn_Off_08 = true;
        StopCoroutine("Box_Cha_Idle_08");
    }
    public void Loof_Stop_Box_Cha_IS_Idle_09()
    {
        Turn_Off_09 = true;
        StopCoroutine("Box_Cha_Idle_09");
    }
    //================================================== 
    public void Loof_Stop_Box_Cha_IS_Idle_10()
    {
        Turn_Off_10 = true;
        StopCoroutine("Box_Cha_Idle_10");
    }
    public void Loof_Stop_Box_Cha_IS_Idle_11()
    {
        Turn_Off_11 = true;
        StopCoroutine("Box_Cha_Idle_11");
    }
    public void Loof_Stop_Box_Cha_IS_Idle_12()
    {
        Turn_Off_12 = true;
        StopCoroutine("Box_Cha_Idle_12");
    }






    //============================================================================================================================= 9
    // 방 아이의 상태가 지침 상태  
    public void Loof_Play_Box_Cha_IS_Tired_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[9].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_01[9].Play();

        Loof_Stop_Box_Cha_IS_Idle_01();
        Loof_Stop_Box_Cha_IS_Trash_01();
    }
    public void Loof_Play_Box_Cha_IS_Tired_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[9].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_02[9].Play();

        Loof_Stop_Box_Cha_IS_Idle_02();
        Loof_Stop_Box_Cha_IS_Trash_02();
    }
    public void Loof_Play_Box_Cha_IS_Tired_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[9].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_03[9].Play();

        Loof_Stop_Box_Cha_IS_Idle_03();
        Loof_Stop_Box_Cha_IS_Trash_03();
    }
    //================================================== 
    public void Loof_Play_Box_Cha_IS_Tired_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[9].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_04[9].Play();

        Loof_Stop_Box_Cha_IS_Idle_04();
        Loof_Stop_Box_Cha_IS_Trash_04();
    }
    public void Loof_Play_Box_Cha_IS_Tired_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[9].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_05[9].Play();

        Loof_Stop_Box_Cha_IS_Idle_05();
        Loof_Stop_Box_Cha_IS_Trash_05();
    }
    public void Loof_Play_Box_Cha_IS_Tired_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[9].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_06[9].Play();

        Loof_Stop_Box_Cha_IS_Idle_06();
        Loof_Stop_Box_Cha_IS_Trash_06();
    }
    //================================================== 
    public void Loof_Play_Box_Cha_IS_Tired_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[9].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_07[9].Play();

        Loof_Stop_Box_Cha_IS_Idle_07();
        Loof_Stop_Box_Cha_IS_Trash_07();
    }
    public void Loof_Play_Box_Cha_IS_Tired_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[9].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_08[9].Play();

        Loof_Stop_Box_Cha_IS_Idle_08();
        Loof_Stop_Box_Cha_IS_Trash_08();
    }
    public void Loof_Play_Box_Cha_IS_Tired_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[9].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_09[9].Play();

        Loof_Stop_Box_Cha_IS_Idle_09();
        Loof_Stop_Box_Cha_IS_Trash_09();
    }
    //================================================== 
    public void Loof_Play_Box_Cha_IS_Tired_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[9].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_10[9].Play();

        Loof_Stop_Box_Cha_IS_Idle_10();
        Loof_Stop_Box_Cha_IS_Trash_10();
    }
    public void Loof_Play_Box_Cha_IS_Tired_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[9].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_11[9].Play();

        Loof_Stop_Box_Cha_IS_Idle_11();
        Loof_Stop_Box_Cha_IS_Trash_11();
    }
    public void Loof_Play_Box_Cha_IS_Tired_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[9].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_12[9].Play();

        Loof_Stop_Box_Cha_IS_Idle_12();
        Loof_Stop_Box_Cha_IS_Trash_12();
    }

    //============================================================================================ Stop

    public void Loof_Stop_Box_Cha_IS_Tired_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[9].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_01[9].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Tired_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[9].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_02[9].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Tired_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[9].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_03[9].Stop();
    }
    //================================================== 
    public void Loof_Stop_Box_Cha_IS_Tired_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[9].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_04[9].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Tired_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[9].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_05[9].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Tired_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[9].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_06[9].Stop();
    }
    //================================================== 
    public void Loof_Stop_Box_Cha_IS_Tired_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[9].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_07[9].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Tired_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[9].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_08[9].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Tired_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[9].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_09[9].Stop();
    }
    //================================================== 
    public void Loof_Stop_Box_Cha_IS_Tired_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[9].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_10[9].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Tired_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[9].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_11[9].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Tired_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[9].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_12[9].Stop();
    }





    //============================================================================================================================= 9
    // 방 아이의 상태가 쓰레기 상태   
    public void Loof_Play_Box_Cha_IS_Trash_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[10].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_01[10].Play();

        Loof_Stop_Box_Cha_IS_Idle_01();
        Loof_Stop_Box_Cha_IS_Tired_01();
    }
    public void Loof_Play_Box_Cha_IS_Trash_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[10].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_02[10].Play();

        Loof_Stop_Box_Cha_IS_Idle_02();
        Loof_Stop_Box_Cha_IS_Tired_02();
    }
    public void Loof_Play_Box_Cha_IS_Trash_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[10].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_03[10].Play();

        Loof_Stop_Box_Cha_IS_Idle_03();
        Loof_Stop_Box_Cha_IS_Tired_03();
    }
    //================================================== 
    public void Loof_Play_Box_Cha_IS_Trash_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[10].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_04[10].Play();

        Loof_Stop_Box_Cha_IS_Idle_04();
        Loof_Stop_Box_Cha_IS_Tired_04();
    }
    public void Loof_Play_Box_Cha_IS_Trash_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[10].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_05[10].Play();

        Loof_Stop_Box_Cha_IS_Idle_05();
        Loof_Stop_Box_Cha_IS_Tired_05();
    }
    public void Loof_Play_Box_Cha_IS_Trash_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[10].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_06[10].Play();

        Loof_Stop_Box_Cha_IS_Idle_06();
        Loof_Stop_Box_Cha_IS_Tired_06();
    }
    //================================================== 
    public void Loof_Play_Box_Cha_IS_Trash_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[10].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_07[10].Play();

        Loof_Stop_Box_Cha_IS_Idle_07();
        Loof_Stop_Box_Cha_IS_Tired_07();
    }
    public void Loof_Play_Box_Cha_IS_Trash_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[10].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_08[10].Play();

        Loof_Stop_Box_Cha_IS_Idle_08();
        Loof_Stop_Box_Cha_IS_Tired_08();
    }
    public void Loof_Play_Box_Cha_IS_Trash_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[10].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_09[10].Play();

        Loof_Stop_Box_Cha_IS_Idle_09();
        Loof_Stop_Box_Cha_IS_Tired_09();
    }
    //================================================== 
    public void Loof_Play_Box_Cha_IS_Trash_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[10].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_10[10].Play();

        Loof_Stop_Box_Cha_IS_Idle_10();
        Loof_Stop_Box_Cha_IS_Tired_10();
    }
    public void Loof_Play_Box_Cha_IS_Trash_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[10].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_11[10].Play();

        Loof_Stop_Box_Cha_IS_Idle_11();
        Loof_Stop_Box_Cha_IS_Tired_11();
    }
    public void Loof_Play_Box_Cha_IS_Trash_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[10].loop = true;
        Room_bgm_While_Ani_On_Audio_Source_12[10].Play();

        Loof_Stop_Box_Cha_IS_Idle_12();
        Loof_Stop_Box_Cha_IS_Tired_12();
    }

    //============================================================================================ Stop

    public void Loof_Stop_Box_Cha_IS_Trash_01()
    {
        Room_bgm_While_Ani_On_Audio_Source_01[10].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_01[10].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Trash_02()
    {
        Room_bgm_While_Ani_On_Audio_Source_02[10].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_02[10].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Trash_03()
    {
        Room_bgm_While_Ani_On_Audio_Source_03[10].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_03[10].Stop();
    }
    //================================================== 
    public void Loof_Stop_Box_Cha_IS_Trash_04()
    {
        Room_bgm_While_Ani_On_Audio_Source_04[10].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_04[10].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Trash_05()
    {
        Room_bgm_While_Ani_On_Audio_Source_05[10].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_05[10].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Trash_06()
    {
        Room_bgm_While_Ani_On_Audio_Source_06[10].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_06[10].Stop();
    }
    //================================================== 
    public void Loof_Stop_Box_Cha_IS_Trash_07()
    {
        Room_bgm_While_Ani_On_Audio_Source_07[10].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_07[10].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Trash_08()
    {
        Room_bgm_While_Ani_On_Audio_Source_08[10].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_08[10].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Trash_09()
    {
        Room_bgm_While_Ani_On_Audio_Source_09[10].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_09[10].Stop();
    }
    //================================================== 
    public void Loof_Stop_Box_Cha_IS_Trash_10()
    {
        Room_bgm_While_Ani_On_Audio_Source_10[10].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_10[10].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Trash_11()
    {
        Room_bgm_While_Ani_On_Audio_Source_11[10].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_11[10].Stop();
    }
    public void Loof_Stop_Box_Cha_IS_Trash_12()
    {
        Room_bgm_While_Ani_On_Audio_Source_12[10].loop = false;
        Room_bgm_While_Ani_On_Audio_Source_12[10].Stop();
    }





    public void Stop_Box_Loop_Sound_01()
    {
        Loof_Stop_Box_Cha_IS_Idle_01();
        Loof_Stop_Box_Cha_IS_Tired_01();
        Loof_Stop_Box_Cha_IS_Trash_01();
    }
    public void Stop_Box_Loop_Sound_02()
    {
        Loof_Stop_Box_Cha_IS_Idle_02();
        Loof_Stop_Box_Cha_IS_Tired_02();
        Loof_Stop_Box_Cha_IS_Trash_02();
    }
    public void Stop_Box_Loop_Sound_03()
    {
        Loof_Stop_Box_Cha_IS_Idle_03();
        Loof_Stop_Box_Cha_IS_Tired_03();
        Loof_Stop_Box_Cha_IS_Trash_03();

    }
    public void Stop_Box_Loop_Sound_04()
    {
        Loof_Stop_Box_Cha_IS_Idle_04();
        Loof_Stop_Box_Cha_IS_Tired_04();
        Loof_Stop_Box_Cha_IS_Trash_04();
    }
    public void Stop_Box_Loop_Sound_05()
    {
        Loof_Stop_Box_Cha_IS_Idle_05();
        Loof_Stop_Box_Cha_IS_Tired_05();
        Loof_Stop_Box_Cha_IS_Trash_05();
    }
    public void Stop_Box_Loop_Sound_06()
    {
        Loof_Stop_Box_Cha_IS_Idle_06();
        Loof_Stop_Box_Cha_IS_Tired_06();
        Loof_Stop_Box_Cha_IS_Trash_06();
    }
    public void Stop_Box_Loop_Sound_07()
    {
        Loof_Stop_Box_Cha_IS_Idle_07();
        Loof_Stop_Box_Cha_IS_Tired_07();
        Loof_Stop_Box_Cha_IS_Trash_07();

    }
    public void Stop_Box_Loop_Sound_08()
    {
        Loof_Stop_Box_Cha_IS_Idle_08();
        Loof_Stop_Box_Cha_IS_Tired_08();
        Loof_Stop_Box_Cha_IS_Trash_08();
    }
    public void Stop_Box_Loop_Sound_09()
    {
        Loof_Stop_Box_Cha_IS_Idle_09();
        Loof_Stop_Box_Cha_IS_Tired_09();
        Loof_Stop_Box_Cha_IS_Trash_09();
    }
    public void Stop_Box_Loop_Sound_10()
    {
        Loof_Stop_Box_Cha_IS_Idle_10();
        Loof_Stop_Box_Cha_IS_Tired_10();
        Loof_Stop_Box_Cha_IS_Trash_10();
    }
    public void Stop_Box_Loop_Sound_11()
    {
        Loof_Stop_Box_Cha_IS_Idle_11();
        Loof_Stop_Box_Cha_IS_Tired_11();
        Loof_Stop_Box_Cha_IS_Trash_11();
    }
    public void Stop_Box_Loop_Sound_12()
    {
        Loof_Stop_Box_Cha_IS_Idle_12();
        Loof_Stop_Box_Cha_IS_Tired_12();
        Loof_Stop_Box_Cha_IS_Trash_12();
    }


    //============================================================================================================================= 냉동고 어는 소리 
    // 냉동 중~!
    public void Loop_Play_Frige_Loading_BGM_01()
    {
        Frige_bgm_While_Ani_On_Audio_Source[0].loop = true;
        Frige_bgm_While_Ani_On_Audio_Source[0].Play();
    }
    public void Loop_Play_Frige_Loading_BGM_02()
    {
        Frige_bgm_While_Ani_On_Audio_Source[1].loop = true;
        Frige_bgm_While_Ani_On_Audio_Source[1].Play();
    }
    public void Loop_Play_Frige_Loading_BGM_03()
    {
        Frige_bgm_While_Ani_On_Audio_Source[2].loop = true;
        Frige_bgm_While_Ani_On_Audio_Source[2].Play();
    }
    public void Loop_Play_Frige_Loading_BGM_04()
    {
        Frige_bgm_While_Ani_On_Audio_Source[3].loop = true;
        Frige_bgm_While_Ani_On_Audio_Source[3].Play();
    }

    //============================================================================================ Stop

    public void Loop_Stop_Frige_Loading_BGM_01()
    {
        Frige_bgm_While_Ani_On_Audio_Source[0].loop = false;
        Frige_bgm_While_Ani_On_Audio_Source[0].Stop();
    }
    public void Loop_Stop_Frige_Loading_BGM_02()
    {
        Frige_bgm_While_Ani_On_Audio_Source[1].loop = false;
        Frige_bgm_While_Ani_On_Audio_Source[1].Stop();
    }
    public void Loop_Stop_Frige_Loading_BGM_03()
    {
        Frige_bgm_While_Ani_On_Audio_Source[2].loop = false;
        Frige_bgm_While_Ani_On_Audio_Source[2].Stop();
    }
    public void Loop_Stop_Frige_Loading_BGM_04()
    {
        Frige_bgm_While_Ani_On_Audio_Source[3].loop = false;
        Frige_bgm_While_Ani_On_Audio_Source[3].Stop();
    }








    IEnumerator Box_Cha_Idle_01()
    {       
        if (Turn_Off_01 == true)
        {
            yield break;
        }
        
        for (int i = 0; i < Cha_Idle_AudioClip.Length; i++)
        {
            Cha_Idle_Audio_Source[0].clip = Cha_Idle_AudioClip[i];
            Cha_Idle_Audio_Source[0].Play();
            yield return new WaitForSeconds(Random.Range(0.3F,0.4F));
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Box_Cha_Idle_01");
    }
    IEnumerator Box_Cha_Idle_02()
    {
        if (Turn_Off_02 == true)
        {
            yield break;
        }

        for (int i = 0; i < Cha_Idle_AudioClip.Length; i++)
        {
            Cha_Idle_Audio_Source[1].clip = Cha_Idle_AudioClip[i];
            Cha_Idle_Audio_Source[1].Play();
            yield return new WaitForSeconds(Random.Range(0.3F, 0.4F));
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Box_Cha_Idle_02");
    }
    IEnumerator Box_Cha_Idle_03()
    {
        if (Turn_Off_03 == true)
        {
            yield break;
        }

        for (int i = 0; i < Cha_Idle_AudioClip.Length; i++)
        {
            Cha_Idle_Audio_Source[2].clip = Cha_Idle_AudioClip[i];
            Cha_Idle_Audio_Source[2].Play();
            yield return new WaitForSeconds(Random.Range(0.3F, 0.4F));
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Box_Cha_Idle_03");
    }
    IEnumerator Box_Cha_Idle_04()
    {
        if (Turn_Off_04 == true)
        {
            yield break;
        }

        for (int i = 0; i < Cha_Idle_AudioClip.Length; i++)
        {
            Cha_Idle_Audio_Source[3].clip = Cha_Idle_AudioClip[i];
            Cha_Idle_Audio_Source[3].Play();
            yield return new WaitForSeconds(Random.Range(0.3F, 0.4F));
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Box_Cha_Idle_04");
    }
    IEnumerator Box_Cha_Idle_05()
    {
        if (Turn_Off_05 == true)
        {
            yield break;
        }

        for (int i = 0; i < Cha_Idle_AudioClip.Length; i++)
        {
            Cha_Idle_Audio_Source[4].clip = Cha_Idle_AudioClip[i];
            Cha_Idle_Audio_Source[4].Play();
            yield return new WaitForSeconds(Random.Range(0.3F, 0.4F));
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Box_Cha_Idle_05");
    }
    IEnumerator Box_Cha_Idle_06()
    {
        if (Turn_Off_01 == true)
        {
            yield break;
        }

        for (int i = 0; i < Cha_Idle_AudioClip.Length; i++)
        {
            Cha_Idle_Audio_Source[5].clip = Cha_Idle_AudioClip[i];
            Cha_Idle_Audio_Source[5].Play();
            yield return new WaitForSeconds(Random.Range(0.3F, 0.4F));
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Box_Cha_Idle_06");
    }
    IEnumerator Box_Cha_Idle_07()
    {
        if (Turn_Off_07 == true)
        {
            yield break;
        }

        for (int i = 0; i < Cha_Idle_AudioClip.Length; i++)
        {
            Cha_Idle_Audio_Source[6].clip = Cha_Idle_AudioClip[i];
            Cha_Idle_Audio_Source[6].Play();
            yield return new WaitForSeconds(Random.Range(0.3F, 0.4F));
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Box_Cha_Idle_07");
    }
    IEnumerator Box_Cha_Idle_08()
    {
        if (Turn_Off_08 == true)
        {
            yield break;
        }

        for (int i = 0; i < Cha_Idle_AudioClip.Length; i++)
        {
            Cha_Idle_Audio_Source[7].clip = Cha_Idle_AudioClip[i];
            Cha_Idle_Audio_Source[7].Play();
            yield return new WaitForSeconds(Random.Range(0.3F, 0.4F));
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Box_Cha_Idle_08");
    }
    IEnumerator Box_Cha_Idle_09()
    {
        if (Turn_Off_09 == true)
        {
            yield break;
        }

        for (int i = 0; i < Cha_Idle_AudioClip.Length; i++)
        {
            Cha_Idle_Audio_Source[8].clip = Cha_Idle_AudioClip[i];
            Cha_Idle_Audio_Source[8].Play();
            yield return new WaitForSeconds(Random.Range(0.3F, 0.4F));
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Box_Cha_Idle_09");
    }
    IEnumerator Box_Cha_Idle_10()
    {
        if (Turn_Off_10 == true)
        {
            yield break;
        }

        for (int i = 0; i < Cha_Idle_AudioClip.Length; i++)
        {
            Cha_Idle_Audio_Source[9].clip = Cha_Idle_AudioClip[i];
            Cha_Idle_Audio_Source[9].Play();
            yield return new WaitForSeconds(Random.Range(0.3F, 0.4F));
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Box_Cha_Idle_10");
    }
    IEnumerator Box_Cha_Idle_11()
    {
        if (Turn_Off_11 == true)
        {
            yield break;
        }

        for (int i = 0; i < Cha_Idle_AudioClip.Length; i++)
        {
            Cha_Idle_Audio_Source[10].clip = Cha_Idle_AudioClip[i];
            Cha_Idle_Audio_Source[10].Play();
            yield return new WaitForSeconds(Random.Range(0.3F, 0.4F));
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Box_Cha_Idle_11");
    }
    IEnumerator Box_Cha_Idle_12()
    {
        if (Turn_Off_12 == true)
        {
            yield break;
        }

        for (int i = 0; i < Cha_Idle_AudioClip.Length; i++)
        {
            Cha_Idle_Audio_Source[11].clip = Cha_Idle_AudioClip[i];
            Cha_Idle_Audio_Source[11].Play();
            yield return new WaitForSeconds(Random.Range(0.3F, 0.4F));
        }

        yield return new WaitForSeconds(5f);
        StartCoroutine("Box_Cha_Idle_12");
    }






    //============================================================
    /*
    0 = bgm_Basic_Main                      // LOOP
    1 = bgm_Frige_Main                      // LOOP
    2 = bgm_Escape_Sound                   // LOOP
    3 = bgm_Delivery_Sound
    4 = bgm_Stage_Clear
    5 = Button_Click
    6 = Scene_Change 
    7 = Cha_Buy || Room_Buy 
    8 = Room_Click
    9 = Order_Time_Coming
    */
    //============================================================


    //Room_Ani +  // LOOP
    //============================================================
    /*
    0 = 먹기
    1 = 목욕
    2 = bgm_Escape_Danger_Sound
    3 = bgm_Delivery_Sound
    */
    //============================================================
}
