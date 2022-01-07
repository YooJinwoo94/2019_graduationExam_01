using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stop_Manager : MonoBehaviour {

    public bool is_Stop_On;
    public UIPanel Stop_Panel;
    public UIPanel Option_Panel;
    public Sound_Manager Sound_Man_Script;
    public Option_Manager Option_Man_Script;




    private void Awake()
    {
        Stop_Panel.alpha = 0f;
    }



    private void Update()
    {
        if (Option_Man_Script.is_Option_On == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (is_Stop_On == false)
                {
                    Sound_Man_Script.Play_Scene_Change();

                    is_Stop_On = true;
                    Stop_Panel.alpha = 1f;

                    Time_Stop();
                }

                else if (is_Stop_On == true)
                {
                    is_Stop_On = false;
                    Stop_Panel.alpha = 0f;

                    Time_GO();

                    Sound_Man_Script.Play_Scene_Change();
                }
            }
        }
    }



    public void Stop_Panel_On()
    {
        Stop_Panel.alpha = 1f;
    }



    //=================================== 나가기 버튼 + 이어가기 버튼 
    public void Stop_Panel_Off()
    {
        if (is_Stop_On == true)
        {
            Sound_Man_Script.Play_Button_Click();
            Sound_Man_Script.Play_Scene_Change();

            is_Stop_On = false;
            Stop_Panel.alpha = 0f;

            Time_GO();
        }
    }
    //=================================== 메인 화면 
    public void Main_Button()
    {
        Sound_Man_Script.Play_Button_Click();
        SceneManager.LoadScene("Title_Scene");
    }
    //=================================== 옵션
    public void Open_Option_Button()
    {
        Sound_Man_Script.Play_Button_Click();
        Sound_Man_Script.Play_Scene_Change();
        Stop_Panel.alpha = 0;
        Option_Man_Script.Option_Panel_On();

    }
    //=================================== 게임 종료 
    public void Game_Out_Button()
    {
        Sound_Man_Script.Play_Button_Click();
        Application.Quit();
    }

    private void Time_Stop()
    {
        Time.timeScale = 0f;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
    }
    private void Time_GO()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
    }

}
