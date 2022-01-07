using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_Cha_Type_11 : MonoBehaviour {

    public Food_Cha_Type Food_Cha_Type;

    public Cha_Grow_Up_11 _Grow_Up_Script;



    //3번방

    // 밥먹기
    public void Eat_Food_Ani()
    {
        //A타입
        if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_A)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "A_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_11" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_12")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "A_01_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "A_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_11" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_12")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "A_02_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //B타입
        if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_B)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "B_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "B_01_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "B_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_11")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "B_02_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //C타입
        if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_C)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "C_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_09")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "C_01_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "C_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "C_02_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //D타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_D)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "D_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_08")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "D_01_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "D_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_08")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "D_02_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //E타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_E)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "E_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "E_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "E_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "E_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "E_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "E_01_Idle_06")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "E_01_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "E_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_11" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_12")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "E_02_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //F타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_F)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //G타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_G)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "G_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_05")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "G_01_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "G_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_06")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "G_02_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //H타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_H)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //I타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_I)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //J타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_J)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "J_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "J_01_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "J_02_Idle_01" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_02" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_03" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_04" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_05" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_06" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_07" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_08" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_09" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "J_02_Eat_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
    //======================================================
    // 샤워
    public void Shower_Ani()
    {
        //A타입
        if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_A)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "A_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_11" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_12")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "A_01_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "A_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_11" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_12")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "A_02_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //B타입
        if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_B)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "B_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "B_01_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "B_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_11")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "B_02_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //C타입
        if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_C)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "C_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_09")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "C_01_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "C_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "C_02_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //D타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_D)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "D_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_08")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "D_01_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "D_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_08")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "D_02_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //E타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_E)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "E_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "E_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "E_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "E_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "E_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "E_01_Idle_06")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "E_01_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "E_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_11" ||
                _Grow_Up_Script.Cha.spriteName == "E_02_Idle_12")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "E_02_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //F타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_F)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //G타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_G)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "G_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_05")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "G_01_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "G_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_06")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "G_02_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //H타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_H)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //I타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_I)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //J타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_J)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "J_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "J_01_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "J_02_Idle_01" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_02" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_03" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_04" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_05" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_06" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_07" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_08" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_09" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "J_02_Shower_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
    //======================================================
    // 운동
    public void Exercise_Ani()
    {
        //A타입
        if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_A)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "A_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_11" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_12")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "A_01_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "A_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_11" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_12")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "A_02_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //B타입
        if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_B)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "B_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "B_01_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "B_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_11")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "B_02_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //03단계
            else if (_Grow_Up_Script.Cha.spriteName == "B_03_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "B_03_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "B_03_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "B_03_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "B_03_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "B_03_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "B_03_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "B_03_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "B_03_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "B_03_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //C타입
        if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_C)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "C_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_09")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "C_01_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "C_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "C_02_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //D타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_D)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "D_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_08")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "D_01_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "D_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_08")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "D_02_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //E타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_E)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "G_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_05")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "G_01_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "G_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_06")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "G_02_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //F타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_F)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //G타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_G)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "G_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_05")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "G_01_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "G_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_06")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "G_02_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //H타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_H)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //I타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_I)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //J타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_J)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "J_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "J_01_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "J_02_Idle_01" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_02" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_03" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_04" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_05" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_06" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_07" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_08" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_09" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "J_02_Exercise_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
    //======================================================
    // 잠자기 
    public void Sleep_Ani()
    {
        //A타입
        if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_A)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "A_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_11" ||
                _Grow_Up_Script.Cha.spriteName == "A_01_Idle_12")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "A_01_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "A_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_11" ||
                _Grow_Up_Script.Cha.spriteName == "A_02_Idle_12")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "A_02_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //B타입
        if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_B)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "B_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "B_01_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "B_01_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "B_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_10" ||
                _Grow_Up_Script.Cha.spriteName == "B_02_Idle_11")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "B_02_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //C타입
        if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_C)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "C_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "C_01_Idle_09")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "C_01_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "C_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "C_02_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "C_02_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //D타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_D)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "D_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "D_01_Idle_08")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "D_01_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "D_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "D_02_Idle_08")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "D_02_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //E타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_E)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "G_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_05")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "G_01_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "G_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_06")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "G_02_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //F타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_F)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //G타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_G)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "G_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "G_01_Idle_05")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "G_01_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "G_02_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "G_02_Idle_06")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "G_02_Sleep_01";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //H타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_H)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //I타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_I)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "")
            {

            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //J타입
        else if (_Grow_Up_Script._Type_Of_Cha == Cha_Type.Like_J)
        {
            //01단계
            if (_Grow_Up_Script.Cha.spriteName == "J_01_Idle_01" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_02" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_03" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_04" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_05" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_06" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_07" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_08" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_09" ||
                _Grow_Up_Script.Cha.spriteName == "J_01_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "J_01_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
            //02단계
            else if (_Grow_Up_Script.Cha.spriteName == "J_02_Idle_01" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_02" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_03" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_04" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_05" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_06" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_07" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_08" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_09" ||
           _Grow_Up_Script.Cha.spriteName == "J_02_Idle_10")
            {
                _Grow_Up_Script._UI_Sprite_Animation.namePrefix = "J_02_Sleep_";
                _Grow_Up_Script._UI_Sprite_Animation.framesPerSecond = 10;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
