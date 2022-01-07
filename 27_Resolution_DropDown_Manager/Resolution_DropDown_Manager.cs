using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resolution_DropDown_Manager : MonoBehaviour {

    public UILabel resolution_Label;
    public UIPopupList resolution_Drop_Down;

    public Sound_Manager Sound_Man_Script;

    Resolution[] resolutions;
    
    private void Awake()
    {
        resolutions = Screen.resolutions;

        //====================================
        resolutions[0].width = 720;
        resolutions[0].height = 480;
        //====================================

        //====================================
        resolutions[1].width = 1280;
        resolutions[1].height = 720;
        //====================================

        //====================================
        resolutions[2].width = 1920;
        resolutions[2].height = 1080;
        //====================================

    }

    public void Set_Resolution(int resoultion_Index)
    {
        if (resolution_Label.text == "720 x 480")
        {
            Sound_Man_Script.Play_Button_Click();

            Resolution resolution = resolutions[0];
            Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

            Debug.Log(resolution);
        }

        else if (resolution_Label.text == "1280 x 720")
        {
            Sound_Man_Script.Play_Button_Click();

            Resolution resolution = resolutions[1];
            Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

            Debug.Log(resolution);
        }
        else if (resolution_Label.text == "1920 x 1080")
        {
            Sound_Man_Script.Play_Button_Click();

            Resolution resolution = resolutions[2];
            Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

            Debug.Log(resolution);
        }
    }
}
