using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Manager : MonoBehaviour {
    public UIPanel Inventory_Panel;

    // 내가 누른 아이의 이름을 받아와야한다.
    public string Cha_Name;

    public Status_Manager Status_Man_Script;
    public Player_Happy_Manager Player_Happy_Man_Script;
    public Sound_Manager Sound_Man_Script;
    public Give_Food_To_Customer_Manager _Give_Food_To_Customer_Man;

    public Give_Food_To_Customer_Controller_01 Quest_01;
    public Give_Food_To_Customer_Controller_02 Quest_02;
    public Give_Food_To_Customer_Controller_03 Quest_03;
    public Give_Food_To_Customer_Controller_04 Quest_04;

    public UIPanel Order_Ui_Panel_01;
    public UIPanel Order_Ui_Panel_02;
    public UIPanel Order_Ui_Panel_03;
    public UIPanel Order_Ui_Panel_04;

    public Inventory_Controller Inventory_Controller_01;
    public Inventory_Controller Inventory_Controller_02;
    public Inventory_Controller Inventory_Controller_03;
    public Inventory_Controller Inventory_Controller_04;
    public Inventory_Controller Inventory_Controller_05;
    public Inventory_Controller Inventory_Controller_06;
    public Inventory_Controller Inventory_Controller_07;
    public Inventory_Controller Inventory_Controller_08;
    public Inventory_Controller Inventory_Controller_09;
    public Inventory_Controller Inventory_Controller_10;
    public Inventory_Controller Inventory_Controller_11;
    public Inventory_Controller Inventory_Controller_12;
    public Inventory_Controller Inventory_Controller_13;
    public Inventory_Controller Inventory_Controller_14;
    public Inventory_Controller Inventory_Controller_15;
    public Inventory_Controller Inventory_Controller_16;
    public Inventory_Controller Inventory_Controller_17;
    public Inventory_Controller Inventory_Controller_18;
    public Inventory_Controller Inventory_Controller_19;
    public Inventory_Controller Inventory_Controller_20;

    public bool IS_Inven_On;

    public bool Is_Order_01;
    public bool Is_Order_02;
    public bool Is_Order_03;
    public bool Is_Order_04;
    public bool Is_Order_05;
    public bool Is_Order_06;
    public bool Is_Order_07;
    public bool Is_Order_08;
    public bool Is_Order_09;
    public bool Is_Order_10;
    public bool Is_Order_11;
    public bool Is_Order_12;
    public bool Is_Order_13;
    public bool Is_Order_14;
    public bool Is_Order_15;
    public bool Is_Order_16;
    public bool Is_Order_17;
    public bool Is_Order_18;
    public bool Is_Order_19;
    public bool Is_Order_20;

    private bool Check_Bool_A;
    private bool Check_Bool_B;
    private bool Check_Bool_C;
    private bool Check_Bool_D;
    private bool Check_Bool_E;
    private bool Check_Bool_F;
    private bool Check_Bool_G;
    private bool Check_Bool_H;
    private bool Check_Bool_I;
    private bool Check_Bool_J;


    private int Player_Get_Happy_A;
    private int Player_Get_Happy_B;
    private int Player_Get_Happy_C;
    private int Player_Get_Happy_D;
    private int Player_Get_Happy_E;
    private int Player_Get_Happy_F;
    private int Player_Get_Happy_G;
    private int Player_Get_Happy_H;
    private int Player_Get_Happy_I;

    private int Player_Get_Coin_A;
    private int Player_Get_Coin_B;
    private int Player_Get_Coin_C;
    private int Player_Get_Coin_D;
    private int Player_Get_Coin_E;
    private int Player_Get_Coin_F;
    private int Player_Get_Coin_G;
    private int Player_Get_Coin_H;
    private int Player_Get_Coin_I;

    public int Count_Order;



    private void Awake()
    {
        Is_Order_01 = true;

        Player_Get_Happy_A = 5;
        Player_Get_Happy_B = 6;
        Player_Get_Happy_C = 10;
        Player_Get_Happy_D = 7;
        Player_Get_Happy_E = 7;
        Player_Get_Happy_F = 7;
        Player_Get_Happy_G = 8;
        Player_Get_Happy_H = 7;
        Player_Get_Happy_I = 8;

        Player_Get_Coin_A = 3000;
        Player_Get_Coin_B = 3500;
        Player_Get_Coin_C = 8000;
        Player_Get_Coin_D = 7000;
        Player_Get_Coin_E = 7000;
        Player_Get_Coin_F = 7500;
        Player_Get_Coin_G = 7500;
        Player_Get_Coin_H = 7500;
        Player_Get_Coin_I = 7000;

        Count_Order = 0;
    }




    // 해당 위치 생성 
    public void Inventory_On()
    {
            // 1번 검사하기
            if (Is_Order_01 == true)
        {
            // 중복인 경우                                   =>>>   현재칸에 생성
            if(Inventory_Controller_01.Inventory_Sprite.spriteName == Cha_Name.ToString())
            {
                Inventory_Controller_01.Inventory_Panel.alpha = 1f;
                Inventory_Controller_01.Cha_Count_In_Inventory++;
                Inventory_Controller_01.Check_Count_Cha();
            }

            // 여기가 비어있으니 여기에 생성하겠습니다.       =>>>   현재칸에 생성
            else if (Inventory_Controller_01.Inventory_Sprite.spriteName =="None")
            {
                // 생성 
                Inventory_Controller_01.Inventory_Panel.alpha = 1f;

                // 숫자 증가
                Inventory_Controller_01.Cha_Count_In_Inventory++;
                Inventory_Controller_01.Check_Count_Cha();

                //이미지 변화
                Inventory_Controller_01.Inventory_Sprite.spriteName = Cha_Name.ToString();
            }

            // 중복이 아닌경우 + 빈칸이 아닌 경우            =>>> 다른 칸으로 가세요 
            else if (Inventory_Controller_01.Inventory_Sprite.spriteName != Cha_Name.ToString() && Inventory_Controller_01.Inventory_Sprite.spriteName != "None")
            {
                Is_Order_01 = false;
                Is_Order_02 = true;
            }          
        }
            // 2번 검사하기
            if (Is_Order_01 == false)
          {
            if (Is_Order_02 == true)
            {
                // 중복인 경우                                 =>>>   현재칸에 생성
                if (Inventory_Controller_02.Inventory_Sprite.spriteName == Cha_Name.ToString())
                {
                    Inventory_Controller_02.Inventory_Panel.alpha = 1f;
                    Inventory_Controller_02.Cha_Count_In_Inventory++;
                    Inventory_Controller_02.Check_Count_Cha();
                }

                // 여기가 비어있으니 여기에 생성하겠습니다.    =>>>   현재칸에 생성
                else if (Inventory_Controller_02.Inventory_Sprite.spriteName == "None")
                {
                    // 생성 
                    Inventory_Controller_02.Inventory_Panel.alpha = 1f;

                    // 숫자 증가
                    Inventory_Controller_02.Cha_Count_In_Inventory++;
                    Inventory_Controller_02.Check_Count_Cha();

                    //이미지 변화
                    Inventory_Controller_02.Inventory_Sprite.spriteName = Cha_Name.ToString();
                }

                //중복이 아닌경우 + 빈칸이 아닌 경우           =>>> 다른 칸으로 가세요 
                else if (Inventory_Controller_02.Inventory_Sprite.spriteName != Cha_Name.ToString() && Inventory_Controller_02.Inventory_Sprite.spriteName != "None")
                {
                    Is_Order_02 = false;
                    Is_Order_03 = true;
                }
            }
          }
            // 3번 검사하기
            if (Is_Order_02 == false)
            {
                if (Is_Order_03 == true)
                {
                    // 중복인 경우                                 =>>>   현재칸에 생성
                    if (Inventory_Controller_03.Inventory_Sprite.spriteName == Cha_Name.ToString())
                    {
                        Inventory_Controller_03.Inventory_Panel.alpha = 1f;
                        Inventory_Controller_03.Cha_Count_In_Inventory++;
                        Inventory_Controller_03.Check_Count_Cha();
                    }

                    // 여기가 비어있으니 여기에 생성하겠습니다.    =>>>   현재칸에 생성
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName == "None")
                    {
                        // 생성 
                        Inventory_Controller_03.Inventory_Panel.alpha = 1f;

                        // 숫자 증가
                        Inventory_Controller_03.Cha_Count_In_Inventory++;
                        Inventory_Controller_03.Check_Count_Cha();

                        //이미지 변화
                        Inventory_Controller_03.Inventory_Sprite.spriteName = Cha_Name.ToString();
                    }

                    //중복이 아닌경우 + 빈칸이 아닌 경우           =>>> 다른 칸으로 가세요 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != Cha_Name.ToString() && Inventory_Controller_03.Inventory_Sprite.spriteName != "None")
                    {
                        Is_Order_03 = false;
                        Is_Order_04 = true;
                    }
                }
            }
            // 4번 검사하기 
            if (Is_Order_03 == false)
            {
                if (Is_Order_04 == true)
                {
                    // 중복인 경우                                 =>>>   현재칸에 생성
                    if (Inventory_Controller_04.Inventory_Sprite.spriteName == Cha_Name.ToString())
                    {
                        Inventory_Controller_04.Inventory_Panel.alpha = 1f;
                        Inventory_Controller_04.Cha_Count_In_Inventory++;
                        Inventory_Controller_04.Check_Count_Cha();
                    }

                    // 여기가 비어있으니 여기에 생성하겠습니다.    =>>>   현재칸에 생성
                    else if (Inventory_Controller_04.Inventory_Sprite.spriteName == "None")
                    {
                        // 생성 
                        Inventory_Controller_04.Inventory_Panel.alpha = 1f;

                        // 숫자 증가
                        Inventory_Controller_04.Cha_Count_In_Inventory++;
                        Inventory_Controller_04.Check_Count_Cha();

                        //이미지 변화
                        Inventory_Controller_04.Inventory_Sprite.spriteName = Cha_Name.ToString();
                    }

                    //중복이 아닌경우 + 빈칸이 아닌 경우           =>>> 다른 칸으로 가세요 
                    else if (Inventory_Controller_04.Inventory_Sprite.spriteName != Cha_Name.ToString() && Inventory_Controller_04.Inventory_Sprite.spriteName != "None")
                    {
                        Is_Order_04 = false;
                        Is_Order_05 = true;
                    }
                }
            }
            // 5번 검사하기
            if (Is_Order_04 == false)
                {
                        if(Is_Order_05 == true)
                        {
                            // 중복인 경우                                 =>>>   현재칸에 생성
                            if (Inventory_Controller_05.Inventory_Sprite.spriteName == Cha_Name.ToString())
                            {
                                Inventory_Controller_05.Inventory_Panel.alpha = 1f;
                                Inventory_Controller_05.Cha_Count_In_Inventory++;
                                Inventory_Controller_05.Check_Count_Cha();
                            }

                            // 여기가 비어있으니 여기에 생성하겠습니다.    =>>>   현재칸에 생성
                            else if (Inventory_Controller_05.Inventory_Sprite.spriteName == "None")
                            {
                                // 생성 
                                Inventory_Controller_05.Inventory_Panel.alpha = 1f;

                                // 숫자 증가
                                Inventory_Controller_05.Cha_Count_In_Inventory++;
                                Inventory_Controller_05.Check_Count_Cha();

                                //이미지 변화
                                Inventory_Controller_05.Inventory_Sprite.spriteName = Cha_Name.ToString();                             
                            }

                            //중복이 아닌경우 + 빈칸이 아닌 경우           =>>> 다른 칸으로 가세요 
                            else if (Inventory_Controller_05.Inventory_Sprite.spriteName != Cha_Name.ToString() && Inventory_Controller_05.Inventory_Sprite.spriteName != "None")
                            {
                                Is_Order_05 = false;
                                Is_Order_06 = true;
                            }
                        }
                 }               
        Re_Set_Bool();
    }





    public void Re_Set_Bool()
    {
     Is_Order_01 = true;
     Is_Order_02 = false;
     Is_Order_03 = false;
     Is_Order_04 = false;
     Is_Order_05 = false;
     Is_Order_06 = false;
     Is_Order_07 = false;
     Is_Order_08 = false;
     Is_Order_09 = false;
     Is_Order_10 = false;
     Is_Order_11 = false;
     Is_Order_12 = false;
     Is_Order_13 = false;
     Is_Order_14 = false;
     Is_Order_15 = false;
     Is_Order_16 = false;
     Is_Order_17 = false;
     Is_Order_18 = false;
     Is_Order_19 = false;
     Is_Order_20 = false;
 
       Check_Bool_A = false;
       Check_Bool_B = false;
       Check_Bool_C = false;
       Check_Bool_D = false;
       Check_Bool_E = false;
       Check_Bool_F = false;
       Check_Bool_G = false;
       Check_Bool_H = false;
       Check_Bool_I = false;
       Check_Bool_J = false;

       _Give_Food_To_Customer_Man.A = 0;
       _Give_Food_To_Customer_Man.B = 0;
       _Give_Food_To_Customer_Man.C = 0;
       _Give_Food_To_Customer_Man.D = 0;
       _Give_Food_To_Customer_Man.E = 0;
       _Give_Food_To_Customer_Man.F = 0;
       _Give_Food_To_Customer_Man.G = 0;
       _Give_Food_To_Customer_Man.H = 0;
       _Give_Food_To_Customer_Man.I = 0;

    }





    public void Check_Order_To_Inven()
    {
        // 양파 // 필요한 음식은 A
        if (_Give_Food_To_Customer_Man.Food_A == true)
        {
            Debug.Log("A");

            // 1번 검사하기
            if (Is_Order_01 == true)
            {
                // 물건이 있는 경우                                   
                if (Inventory_Controller_01.Inventory_Sprite.spriteName == "A_03_Idle_01")
                {
                    // 납품 성공 
                    if (Inventory_Controller_01.Cha_Count_In_Inventory >= 1)
                    {
                        // 숫자 감소
                        Inventory_Controller_01.Cha_Count_In_Inventory -= 1;
                        Inventory_Controller_01.Check_Count_Cha();

                        

                        // 성공 여부 알려주기 
                        Quest_01.Food_Fin_01 = true;
                        Quest_02.Food_Fin_02 = true;
                        Quest_03.Food_Fin_03 = true;
                        Quest_04.Food_Fin_04 = true;

                        // 영수증에 보여줄 숫자 
                        Count_Order++;

                        // 성공에 대한 보상을 얻어야 한다. 
                        Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_A);
                        Status_Man_Script.Player_Coin(Player_Get_Coin_A);

                        // 안보이게 하기 
                        if (Inventory_Controller_01.Cha_Count_In_Inventory <= 0)
                        {
                            Inventory_Controller_01.Inventory_Panel.alpha = 0f;
                            Inventory_Controller_01.Inventory_Sprite.spriteName = "None";
                        }
                    }
                }

                // 물건이 없는 경우
               else if (Inventory_Controller_01.Inventory_Sprite.spriteName != "A_03_Idle_01")
                {
                    Is_Order_01 = false;
                    Is_Order_02 = true;
                }
            }

            // 2번 검사하기
            if (Is_Order_01 == false)
            {
                if (Is_Order_02 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_02.Inventory_Sprite.spriteName == "A_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_02.Cha_Count_In_Inventory >= 1)
                        {
                            Debug.Log("성공");
                            // 숫자 감소
                            Inventory_Controller_02.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_02.Check_Count_Cha();

                           

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_A);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_A);

                            // 안보이게 하기 
                            if (Inventory_Controller_02.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_02.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_02.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우
                else if (Inventory_Controller_02.Inventory_Sprite.spriteName != "A_03_Idle_01")
                    {
                        Is_Order_02 = false;
                        Is_Order_03 = true;
                    }
                }
            }

            // 3번 검사하기
            if (Is_Order_02 == false)
            {
                if (Is_Order_03 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_03.Inventory_Sprite.spriteName == "A_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_03.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_03.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_03.Check_Count_Cha();

                           

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_A);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_A);

                            // 안보이게 하기 
                            if (Inventory_Controller_03.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_03.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_03.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    //물건이 없는 경우  
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "A_03_Idle_01")
                    {
                        Is_Order_03 = false;
                        Is_Order_04 = true;
                    }
                }
            }

            // 4번 검사하기 
            if (Is_Order_03 == false)
            {
                if (Is_Order_04 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_04.Inventory_Sprite.spriteName == "A_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_04.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_04.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_04.Check_Count_Cha();

                          

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_A);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_A);

                            // 안보이게 하기 
                            if (Inventory_Controller_04.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_04.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_04.Inventory_Sprite.spriteName = "None";
                            }
                        }

                        // 납품 실패 
                      if (Inventory_Controller_04.Cha_Count_In_Inventory < 1)
                        {
                            // 납품 실패 알림창 생성
                        }
                    }

                    // 물건이 없는 경우 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "A_03_Idle_01")
                    {
                        Is_Order_04 = false;
                        Is_Order_05 = true;
                    }
                }
            }

            // 5번 검사하기
            if (Is_Order_04 == false)
            {
                if (Is_Order_05 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_05.Inventory_Sprite.spriteName == "A_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_05.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_05.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_05.Check_Count_Cha();

                

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_A);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_A);

                            // 안보이게 하기 
                            if (Inventory_Controller_05.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_05.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_05.Inventory_Sprite.spriteName = "None";
                            }
                        }

                        // 납품 실패 
                        else if (Inventory_Controller_05.Cha_Count_In_Inventory < 1)
                        {
                            // 납품 실패 알림창 생성
                        }
                    }

                    // 물건이 없는 경우 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "A_03_Idle_01")
                    {
                        Is_Order_05 = false;
                        Is_Order_06 = true;
                    }
                }
            }
        }

        // 양상추   // 필요한 음식은 B
        if (_Give_Food_To_Customer_Man.Food_B == true)
        {
            Debug.Log("B");

            // 1번 검사하기
            if (Is_Order_01 == true)
            {
                Debug.Log("1");
                // 물건이 있는 경우                                   
                if (Inventory_Controller_01.Inventory_Sprite.spriteName == "B_03_Idle_01")
                {
                    // 납품 성공 
                    if (Inventory_Controller_01.Cha_Count_In_Inventory >= 1)
                    {
                        Debug.Log("성공");
                        // 숫자 감소
                        Inventory_Controller_01.Cha_Count_In_Inventory -= 1;
                        Inventory_Controller_01.Check_Count_Cha();

                        // 성공 여부 알려주기 
                        Quest_01.Food_Fin_01 = true;
                        Quest_02.Food_Fin_02 = true;
                        Quest_03.Food_Fin_03 = true;
                        Quest_04.Food_Fin_04 = true;

                        // 영수증에 보여줄 숫자 
                        Count_Order++;

                        // 성공에 대한 보상을 얻어야 한다. 
                        Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_B);
                        Status_Man_Script.Player_Coin(Player_Get_Coin_B);


                        // 안보이게 하기 
                        if (Inventory_Controller_01.Cha_Count_In_Inventory <= 0)
                        {
                            Inventory_Controller_01.Inventory_Panel.alpha = 0f;
                            Inventory_Controller_01.Inventory_Sprite.spriteName = "None";
                        }
                    }
                }

                // 물건이 없는 경우
              else if (Inventory_Controller_01.Inventory_Sprite.spriteName != "B_03_Idle_01")
                {
                    Is_Order_01 = false;
                    Is_Order_02 = true;
                }
            }

            // 2번 검사하기
            if (Is_Order_01 == false)
            {
                Debug.Log("2");
                if (Is_Order_02 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_02.Inventory_Sprite.spriteName == "B_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_02.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_02.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_02.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_B);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_B);

                            // 안보이게 하기 
                            if (Inventory_Controller_02.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_02.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_02.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우
                    else if (Inventory_Controller_02.Inventory_Sprite.spriteName != "B_03_Idle_01")
                    {
                        Is_Order_02 = false;
                        Is_Order_03 = true;
                    }
                }
            }

            // 3번 검사하기
            if (Is_Order_02 == false)
            {
                if (Is_Order_03 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_03.Inventory_Sprite.spriteName == "B_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_03.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_03.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_03.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_B);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_B);

                            // 안보이게 하기 
                            if (Inventory_Controller_03.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_03.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_03.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    //물건이 없는 경우  
                  else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "B_03_Idle_01")
                    {
                        Is_Order_03 = false;
                        Is_Order_04 = true;
                    }
                }
            }

            // 4번 검사하기 
            if (Is_Order_03 == false)
            {
                if (Is_Order_04 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_04.Inventory_Sprite.spriteName == "B_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_04.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_04.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_04.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_B);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_B);

                            // 안보이게 하기 
                            if (Inventory_Controller_04.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_04.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_04.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우 
                  else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "B_03_Idle_01")
                    {
                        Is_Order_04 = false;
                        Is_Order_05 = true;
                    }
                }
            }

            // 5번 검사하기
            if (Is_Order_04 == false)
            {
                if (Is_Order_05 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_05.Inventory_Sprite.spriteName == "B_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_05.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_05.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_05.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_B);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_B);

                            // 안보이게 하기 
                            if (Inventory_Controller_05.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_05.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_05.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우 
                   else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "B_03_Idle_01")
                    {
                        Is_Order_05 = false;
                        Is_Order_06 = true;
                    }
                }
            }
        }

        // 1+1  // 필요한 음식은 A, B 
        if (_Give_Food_To_Customer_Man.Food_C == true)
        {
            Debug.Log("s");
            // 1번 검사하기
            if (Is_Order_01 == true)
            {
                    // Need_01 인 경우 
                    if (Inventory_Controller_01.Inventory_Sprite.spriteName == "A_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_01.Cha_Count_In_Inventory >= 1)
                        {                       
                            _Give_Food_To_Customer_Man.A++;
                             Check_Bool_A = true;
                        }
                    }

                    // Need_02 인 경우 
                    if (Inventory_Controller_01.Inventory_Sprite.spriteName == "B_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_01.Cha_Count_In_Inventory >= 1)
                        {
                            _Give_Food_To_Customer_Man.B++;
                            Check_Bool_B = true;
                        }
                    }

            // 물건이 없는 경우
              if (Inventory_Controller_01.Inventory_Sprite.spriteName != "A_03_Idle_01" || Inventory_Controller_01.Inventory_Sprite.spriteName != "B_03_Idle_01")
                {
                    Is_Order_01 = false;
                    Is_Order_02 = true;
                }
            }

            // 2번 검사하기
            if (Is_Order_01 == false)
            {
                if (Is_Order_02 == true)
                {
                   // Need_01 인 경우 
                if (Inventory_Controller_02.Inventory_Sprite.spriteName == "A_03_Idle_01" && _Give_Food_To_Customer_Man.A == 0)
                        {
                            // 납품 성공 
                            if (Inventory_Controller_02.Cha_Count_In_Inventory >= 1)
                            {                          
                                _Give_Food_To_Customer_Man.A++;
                                Check_Bool_C = true;
                            }
                        }

                   // Need_02 인 경우 
                if (Inventory_Controller_02.Inventory_Sprite.spriteName == "B_03_Idle_01" && _Give_Food_To_Customer_Man.B == 0)
                        {
                            // 납품 성공 
                            if (Inventory_Controller_02.Cha_Count_In_Inventory >= 1)
                            {
                                // 필요한 재료 확인증 
                                _Give_Food_To_Customer_Man.B++;
                                 Check_Bool_D = true;
                            }
                        }
                    

                    // 물건이 없는 경우
                 if (Inventory_Controller_02.Inventory_Sprite.spriteName != "A_03_Idle_01" || Inventory_Controller_02.Inventory_Sprite.spriteName != "B_03_Idle_01")
                    {
                        Is_Order_02 = false;
                        Is_Order_03 = true;
                    }
                }
            }

            // 3번 검사하기
            if (Is_Order_02 == false )
            {
                if (Is_Order_03 == true)
                {
                   
                        // Need_01 인 경우 
                        if (Inventory_Controller_03.Inventory_Sprite.spriteName == "A_03_Idle_01" && _Give_Food_To_Customer_Man.A == 0)
                        {
                            // 납품 성공 
                            if (Inventory_Controller_03.Cha_Count_In_Inventory >= 1)
                            {
                                _Give_Food_To_Customer_Man.A++;
                            Check_Bool_E = true;
                            }
                        }

                        // Need_02 인 경우 
                        if (Inventory_Controller_03.Inventory_Sprite.spriteName == "B_03_Idle_01" && _Give_Food_To_Customer_Man.B == 0)
                        {
                            // 납품 성공 
                            if (Inventory_Controller_03.Cha_Count_In_Inventory >= 1)
                            {
                                _Give_Food_To_Customer_Man.B++;
                               Check_Bool_F = true;
                        }
                        }
         

                    // 물건이 없는 경우
                  if (Inventory_Controller_03.Inventory_Sprite.spriteName != "A_03_Idle_01" || Inventory_Controller_03.Inventory_Sprite.spriteName != "B_03_Idle_01")
                    {
                        Is_Order_03 = false;
                        Is_Order_04 = true;
                    }
                }
            }

            // 4번 검사하기
            if (Is_Order_03 == false)
            {
                if (Is_Order_04 == true)
                {
                   
                        // Need_01 인 경우 
                        if (Inventory_Controller_04.Inventory_Sprite.spriteName == "A_03_Idle_01" && _Give_Food_To_Customer_Man.A == 0)
                        {
                            // 납품 성공 
                            if (Inventory_Controller_04.Cha_Count_In_Inventory >= 1)
                            {
                                _Give_Food_To_Customer_Man.A++;
                                Check_Bool_G = true;
                        }
                        }

                        // Need_02 인 경우 
                        if (Inventory_Controller_04.Inventory_Sprite.spriteName == "B_03_Idle_01" && _Give_Food_To_Customer_Man.B == 0)
                        {
                            // 납품 성공 
                            if (Inventory_Controller_04.Cha_Count_In_Inventory >= 1)
                            {
                                _Give_Food_To_Customer_Man.B++;
                                  Check_Bool_H = true;
                        }
                        }
              

                    // 물건이 없는 경우
                    if (Inventory_Controller_04.Inventory_Sprite.spriteName != "A_03_Idle_01" || Inventory_Controller_04.Inventory_Sprite.spriteName != "B_03_Idle_01")
                    {
                        Is_Order_04 = false;
                        Is_Order_05 = true;
                    }
                }
            }

            // 5번 검사하기
            if (Is_Order_04 == false)
            {
                if (Is_Order_05 == true)
                {              
                        // Need_01 인 경우 
                        if (Inventory_Controller_05.Inventory_Sprite.spriteName == "A_03_Idle_01" && _Give_Food_To_Customer_Man.A == 0)
                        {
                            // 납품 성공 
                            if (Inventory_Controller_05.Cha_Count_In_Inventory >= 1)
                            {
                                _Give_Food_To_Customer_Man.A++;                             
                                Check_Bool_I = true;
                        }
                        }

                        // Need_02 인 경우  
                        if (Inventory_Controller_05.Inventory_Sprite.spriteName == "B_03_Idle_01" && _Give_Food_To_Customer_Man.B == 0)
                        {
                            // 납품 성공 
                            if (Inventory_Controller_05.Cha_Count_In_Inventory >= 1)
                            {
                                _Give_Food_To_Customer_Man.B++;
                                 Check_Bool_J = true;
                        }
                        }
                    

                    // 물건이 없는 경우
                   if (Inventory_Controller_05.Inventory_Sprite.spriteName != "A_03_Idle_01" || Inventory_Controller_05.Inventory_Sprite.spriteName != "B_03_Idle_01")
                    {
                        Is_Order_05 = false;
                        Is_Order_06 = true;
                    }
                }
            }


            // 낙찰 성공 데스 
            if (_Give_Food_To_Customer_Man.Need_Count_01 == _Give_Food_To_Customer_Man.A && _Give_Food_To_Customer_Man.Need_Count_02 == _Give_Food_To_Customer_Man.B)
            {
                // 성공에 대한 보상을 얻어야 한다. 
                Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_C);
                Status_Man_Script.Player_Coin(Player_Get_Coin_C);

                // 영수증에 보여줄 숫자 
                Count_Order++;

                Debug.Log("실행");

                if (Inventory_Controller_01.Inventory_Sprite.spriteName == "A_03_Idle_01")
                {
                    IS_Inventory_Controller_01_Fin_C();
                }
                if (Inventory_Controller_02.Inventory_Sprite.spriteName == "A_03_Idle_01")
                {
                    IS_Inventory_Controller_02_Fin_C();
                }
                if (Inventory_Controller_03.Inventory_Sprite.spriteName == "A_03_Idle_01")
                {
                    IS_Inventory_Controller_03_Fin_C();
                }
                if (Inventory_Controller_04.Inventory_Sprite.spriteName == "A_03_Idle_01")
                {
                    IS_Inventory_Controller_04_Fin_C();
                }
                if (Inventory_Controller_05.Inventory_Sprite.spriteName == "A_03_Idle_01")
                {
                    IS_Inventory_Controller_05_Fin_C();
                }

                if (Inventory_Controller_01.Inventory_Sprite.spriteName == "B_03_Idle_01")
                {
                    IS_Inventory_Controller_01_Fin_C();
                }
                if (Inventory_Controller_02.Inventory_Sprite.spriteName == "B_03_Idle_01")
                {
                    IS_Inventory_Controller_02_Fin_C();
                }
                if (Inventory_Controller_03.Inventory_Sprite.spriteName == "B_03_Idle_01")
                {
                    IS_Inventory_Controller_03_Fin_C();
                }
                if (Inventory_Controller_04.Inventory_Sprite.spriteName == "B_03_Idle_01")
                {
                    IS_Inventory_Controller_04_Fin_C();
                }
                if (Inventory_Controller_05.Inventory_Sprite.spriteName == "B_03_Idle_01")
                {
                    IS_Inventory_Controller_05_Fin_C();
                }

                // 성공 여부 알려주기 
                Quest_01.Food_Fin_01 = true;
                Quest_02.Food_Fin_02 = true;
                Quest_03.Food_Fin_03 = true;
                Quest_04.Food_Fin_04 = true;
            }                     
        }

        // 토마토   // 필요한 음식은 C
        if (_Give_Food_To_Customer_Man.Food_H == true)
        {
            // 1번 검사하기
            if (Is_Order_01 == true)
            {
                Debug.Log("1");
                // 물건이 있는 경우                                   
                if (Inventory_Controller_01.Inventory_Sprite.spriteName == "C_03_Idle_01")
                {
                    // 납품 성공 
                    if (Inventory_Controller_01.Cha_Count_In_Inventory >= 1)
                    {
                        Debug.Log("성공");
                        // 숫자 감소
                        Inventory_Controller_01.Cha_Count_In_Inventory -= 1;
                        Inventory_Controller_01.Check_Count_Cha();

                        // 성공 여부 알려주기 
                        Quest_01.Food_Fin_01 = true;
                        Quest_02.Food_Fin_02 = true;
                        Quest_03.Food_Fin_03 = true;
                        Quest_04.Food_Fin_04 = true;

                        // 영수증에 보여줄 숫자 
                        Count_Order++;

                        // 성공에 대한 보상을 얻어야 한다. 
                        Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_D);
                        Status_Man_Script.Player_Coin(Player_Get_Coin_D);


                        // 안보이게 하기 
                        if (Inventory_Controller_01.Cha_Count_In_Inventory <= 0)
                        {
                            Inventory_Controller_01.Inventory_Panel.alpha = 0f;
                            Inventory_Controller_01.Inventory_Sprite.spriteName = "None";
                        }
                    }
                }

                // 물건이 없는 경우
                else if (Inventory_Controller_01.Inventory_Sprite.spriteName != "C_03_Idle_01")
                {
                    Is_Order_01 = false;
                    Is_Order_02 = true;
                }
            }

            // 2번 검사하기
            if (Is_Order_01 == false)
            {
                Debug.Log("2");
                if (Is_Order_02 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_02.Inventory_Sprite.spriteName == "C_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_02.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_02.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_02.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_D);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_D);

                            // 안보이게 하기 
                            if (Inventory_Controller_02.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_02.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_02.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우
                    else if (Inventory_Controller_02.Inventory_Sprite.spriteName != "C_03_Idle_01")
                    {
                        Is_Order_02 = false;
                        Is_Order_03 = true;
                    }
                }
            }

            // 3번 검사하기
            if (Is_Order_02 == false)
            {
                if (Is_Order_03 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_03.Inventory_Sprite.spriteName == "C_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_03.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_03.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_03.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_D);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_D);

                            // 안보이게 하기 
                            if (Inventory_Controller_03.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_03.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_03.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    //물건이 없는 경우  
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "C_03_Idle_01")
                    {
                        Is_Order_03 = false;
                        Is_Order_04 = true;
                    }
                }
            }

            // 4번 검사하기 
            if (Is_Order_03 == false)
            {
                if (Is_Order_04 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_04.Inventory_Sprite.spriteName == "C_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_04.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_04.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_04.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_D);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_D);

                            // 안보이게 하기 
                            if (Inventory_Controller_04.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_04.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_04.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "C_03_Idle_01")
                    {
                        Is_Order_04 = false;
                        Is_Order_05 = true;
                    }
                }
            }

            // 5번 검사하기
            if (Is_Order_04 == false)
            {
                if (Is_Order_05 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_05.Inventory_Sprite.spriteName == "C_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_05.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_05.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_05.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_D);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_D);

                            // 안보이게 하기 
                            if (Inventory_Controller_05.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_05.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_05.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "C_03_Idle_01")
                    {
                        Is_Order_05 = false;
                        Is_Order_06 = true;
                    }
                }
            }
        }

        // 고기  // 필요한 음식은 D
        if (_Give_Food_To_Customer_Man.Food_D == true)
        {
            // 1번 검사하기
            if (Is_Order_01 == true)
            {
                Debug.Log("1");
                // 물건이 있는 경우                                   
                if (Inventory_Controller_01.Inventory_Sprite.spriteName == "D_03_Idle_01")
                {
                    // 납품 성공 
                    if (Inventory_Controller_01.Cha_Count_In_Inventory >= 1)
                    {
                        Debug.Log("성공");
                        // 숫자 감소
                        Inventory_Controller_01.Cha_Count_In_Inventory -= 1;
                        Inventory_Controller_01.Check_Count_Cha();

                        // 성공 여부 알려주기 
                        Quest_01.Food_Fin_01 = true;
                        Quest_02.Food_Fin_02 = true;
                        Quest_03.Food_Fin_03 = true;
                        Quest_04.Food_Fin_04 = true;

                        // 영수증에 보여줄 숫자 
                        Count_Order++;

                        // 성공에 대한 보상을 얻어야 한다. 
                        Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_E);
                        Status_Man_Script.Player_Coin(Player_Get_Coin_E);


                        // 안보이게 하기 
                        if (Inventory_Controller_01.Cha_Count_In_Inventory <= 0)
                        {
                            Inventory_Controller_01.Inventory_Panel.alpha = 0f;
                            Inventory_Controller_01.Inventory_Sprite.spriteName = "None";
                        }
                    }
                }

                // 물건이 없는 경우
                else if (Inventory_Controller_01.Inventory_Sprite.spriteName != "D_03_Idle_01")
                {
                    Is_Order_01 = false;
                    Is_Order_02 = true;
                }
            }

            // 2번 검사하기
            if (Is_Order_01 == false)
            {
                Debug.Log("2");
                if (Is_Order_02 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_02.Inventory_Sprite.spriteName == "D_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_02.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_02.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_02.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_E);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_E);

                            // 안보이게 하기 
                            if (Inventory_Controller_02.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_02.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_02.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우
                    else if (Inventory_Controller_02.Inventory_Sprite.spriteName != "D_03_Idle_01")
                    {
                        Is_Order_02 = false;
                        Is_Order_03 = true;
                    }
                }
            }

            // 3번 검사하기
            if (Is_Order_02 == false)
            {
                if (Is_Order_03 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_03.Inventory_Sprite.spriteName == "D_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_03.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_03.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_03.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_E);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_E);

                            // 안보이게 하기 
                            if (Inventory_Controller_03.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_03.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_03.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    //물건이 없는 경우  
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "D_03_Idle_01")
                    {
                        Is_Order_03 = false;
                        Is_Order_04 = true;
                    }
                }
            }

            // 4번 검사하기 
            if (Is_Order_03 == false)
            {
                if (Is_Order_04 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_04.Inventory_Sprite.spriteName == "D_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_04.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_04.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_04.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_E);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_E);

                            // 안보이게 하기 
                            if (Inventory_Controller_04.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_04.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_04.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "D_03_Idle_01")
                    {
                        Is_Order_04 = false;
                        Is_Order_05 = true;
                    }
                }
            }

            // 5번 검사하기
            if (Is_Order_04 == false)
            {
                if (Is_Order_05 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_05.Inventory_Sprite.spriteName == "D_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_05.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_05.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_05.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_E);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_E);

                            // 안보이게 하기 
                            if (Inventory_Controller_05.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_05.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_05.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "D_03_Idle_01")
                    {
                        Is_Order_05 = false;
                        Is_Order_06 = true;
                    }
                }
            }
        }

        // 치킨  // 필요한 음식은 E
        if (_Give_Food_To_Customer_Man.Food_E == true)
        {
            // 1번 검사하기
            if (Is_Order_01 == true)
            {
                Debug.Log("1");
                // 물건이 있는 경우                                   
                if (Inventory_Controller_01.Inventory_Sprite.spriteName == "E_03_Idle_01")
                {
                    // 납품 성공 
                    if (Inventory_Controller_01.Cha_Count_In_Inventory >= 1)
                    {
                        Debug.Log("성공");
                        // 숫자 감소
                        Inventory_Controller_01.Cha_Count_In_Inventory -= 1;
                        Inventory_Controller_01.Check_Count_Cha();

                        // 성공 여부 알려주기 
                        Quest_01.Food_Fin_01 = true;
                        Quest_02.Food_Fin_02 = true;
                        Quest_03.Food_Fin_03 = true;
                        Quest_04.Food_Fin_04 = true;

                        // 영수증에 보여줄 숫자 
                        Count_Order++;

                        // 성공에 대한 보상을 얻어야 한다. 
                        Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_F);
                        Status_Man_Script.Player_Coin(Player_Get_Coin_F);


                        // 안보이게 하기 
                        if (Inventory_Controller_01.Cha_Count_In_Inventory <= 0)
                        {
                            Inventory_Controller_01.Inventory_Panel.alpha = 0f;
                            Inventory_Controller_01.Inventory_Sprite.spriteName = "None";
                        }
                    }
                }

                // 물건이 없는 경우
                else if (Inventory_Controller_01.Inventory_Sprite.spriteName != "E_03_Idle_01")
                {
                    Is_Order_01 = false;
                    Is_Order_02 = true;
                }
            }

            // 2번 검사하기
            if (Is_Order_01 == false)
            {
                Debug.Log("2");
                if (Is_Order_02 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_02.Inventory_Sprite.spriteName == "E_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_02.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_02.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_02.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_F);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_F);

                            // 안보이게 하기 
                            if (Inventory_Controller_02.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_02.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_02.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우
                    else if (Inventory_Controller_02.Inventory_Sprite.spriteName != "E_03_Idle_01")
                    {
                        Is_Order_02 = false;
                        Is_Order_03 = true;
                    }
                }
            }

            // 3번 검사하기
            if (Is_Order_02 == false)
            {
                if (Is_Order_03 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_03.Inventory_Sprite.spriteName == "E_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_03.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_03.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_03.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_F);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_F);

                            // 안보이게 하기 
                            if (Inventory_Controller_03.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_03.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_03.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    //물건이 없는 경우  
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "E_03_Idle_01")
                    {
                        Is_Order_03 = false;
                        Is_Order_04 = true;
                    }
                }
            }

            // 4번 검사하기 
            if (Is_Order_03 == false)
            {
                if (Is_Order_04 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_04.Inventory_Sprite.spriteName == "E_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_04.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_04.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_04.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_F);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_F);

                            // 안보이게 하기 
                            if (Inventory_Controller_04.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_04.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_04.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "E_03_Idle_01")
                    {
                        Is_Order_04 = false;
                        Is_Order_05 = true;
                    }
                }
            }

            // 5번 검사하기
            if (Is_Order_04 == false)
            {
                if (Is_Order_05 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_05.Inventory_Sprite.spriteName == "E_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_05.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_05.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_05.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_F);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_F);

                            // 안보이게 하기 
                            if (Inventory_Controller_05.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_05.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_05.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "E_03_Idle_01")
                    {
                        Is_Order_05 = false;
                        Is_Order_06 = true;
                    }
                }
            }
        }

        // 새우   // 필요한 음식은 F
        if (_Give_Food_To_Customer_Man.Food_F == true)
        {
            // 1번 검사하기
            if (Is_Order_01 == true)
            {
                Debug.Log("1");
                // 물건이 있는 경우                                   
                if (Inventory_Controller_01.Inventory_Sprite.spriteName == "G_03_Idle_01")
                {
                    // 납품 성공 
                    if (Inventory_Controller_01.Cha_Count_In_Inventory >= 1)
                    {
                        Debug.Log("성공");
                        // 숫자 감소
                        Inventory_Controller_01.Cha_Count_In_Inventory -= 1;
                        Inventory_Controller_01.Check_Count_Cha();

                        // 성공 여부 알려주기 
                        Quest_01.Food_Fin_01 = true;
                        Quest_02.Food_Fin_02 = true;
                        Quest_03.Food_Fin_03 = true;
                        Quest_04.Food_Fin_04 = true;

                        // 영수증에 보여줄 숫자 
                        Count_Order++;

                        // 성공에 대한 보상을 얻어야 한다. 
                        Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_G);
                        Status_Man_Script.Player_Coin(Player_Get_Coin_G);


                        // 안보이게 하기 
                        if (Inventory_Controller_01.Cha_Count_In_Inventory <= 0)
                        {
                            Inventory_Controller_01.Inventory_Panel.alpha = 0f;
                            Inventory_Controller_01.Inventory_Sprite.spriteName = "None";
                        }
                    }
                }

                // 물건이 없는 경우
                else if (Inventory_Controller_01.Inventory_Sprite.spriteName != "G_03_Idle_01")
                {
                    Is_Order_01 = false;
                    Is_Order_02 = true;
                }
            }

            // 2번 검사하기
            if (Is_Order_01 == false)
            {
                Debug.Log("2");
                if (Is_Order_02 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_02.Inventory_Sprite.spriteName == "G_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_02.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_02.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_02.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_G);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_G);

                            // 안보이게 하기 
                            if (Inventory_Controller_02.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_02.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_02.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우
                    else if (Inventory_Controller_02.Inventory_Sprite.spriteName != "G_03_Idle_01")
                    {
                        Is_Order_02 = false;
                        Is_Order_03 = true;
                    }
                }
            }

            // 3번 검사하기
            if (Is_Order_02 == false)
            {
                if (Is_Order_03 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_03.Inventory_Sprite.spriteName == "G_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_03.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_03.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_03.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_G);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_G);

                            // 안보이게 하기 
                            if (Inventory_Controller_03.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_03.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_03.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    //물건이 없는 경우  
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "G_03_Idle_01")
                    {
                        Is_Order_03 = false;
                        Is_Order_04 = true;
                    }
                }
            }

            // 4번 검사하기 
            if (Is_Order_03 == false)
            {
                if (Is_Order_04 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_04.Inventory_Sprite.spriteName == "G_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_04.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_04.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_04.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_G);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_G);

                            // 안보이게 하기 
                            if (Inventory_Controller_04.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_04.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_04.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "G_03_Idle_01")
                    {
                        Is_Order_04 = false;
                        Is_Order_05 = true;
                    }
                }
            }

            // 5번 검사하기
            if (Is_Order_04 == false)
            {
                if (Is_Order_05 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_05.Inventory_Sprite.spriteName == "G_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_05.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_05.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_05.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_G);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_G);

                            // 안보이게 하기 
                            if (Inventory_Controller_05.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_05.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_05.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "G_03_Idle_01")
                    {
                        Is_Order_05 = false;
                        Is_Order_06 = true;
                    }
                }
            }
        }

        // 조미료   // 필요한 음식은 G
        if (_Give_Food_To_Customer_Man.Food_G == true)
        {
            // 1번 검사하기
            if (Is_Order_01 == true)
            {
                Debug.Log("1");
                // 물건이 있는 경우                                   
                if (Inventory_Controller_01.Inventory_Sprite.spriteName == "J_03_Idle_01")
                {
                    // 납품 성공 
                    if (Inventory_Controller_01.Cha_Count_In_Inventory >= 1)
                    {
                        Debug.Log("성공");
                        // 숫자 감소
                        Inventory_Controller_01.Cha_Count_In_Inventory -= 1;
                        Inventory_Controller_01.Check_Count_Cha();

                        // 성공 여부 알려주기 
                        Quest_01.Food_Fin_01 = true;
                        Quest_02.Food_Fin_02 = true;
                        Quest_03.Food_Fin_03 = true;
                        Quest_04.Food_Fin_04 = true;

                        // 영수증에 보여줄 숫자 
                        Count_Order++;

                        // 성공에 대한 보상을 얻어야 한다. 
                        Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_H);
                        Status_Man_Script.Player_Coin(Player_Get_Coin_H);


                        // 안보이게 하기 
                        if (Inventory_Controller_01.Cha_Count_In_Inventory <= 0)
                        {
                            Inventory_Controller_01.Inventory_Panel.alpha = 0f;
                            Inventory_Controller_01.Inventory_Sprite.spriteName = "None";
                        }
                    }
                }

                // 물건이 없는 경우
                else if (Inventory_Controller_01.Inventory_Sprite.spriteName != "J_03_Idle_01")
                {
                    Is_Order_01 = false;
                    Is_Order_02 = true;
                }
            }

            // 2번 검사하기
            if (Is_Order_01 == false)
            {
                Debug.Log("2");
                if (Is_Order_02 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_02.Inventory_Sprite.spriteName == "J_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_02.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_02.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_02.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_H);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_H);

                            // 안보이게 하기 
                            if (Inventory_Controller_02.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_02.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_02.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우
                    else if (Inventory_Controller_02.Inventory_Sprite.spriteName != "J_03_Idle_01")
                    {
                        Is_Order_02 = false;
                        Is_Order_03 = true;
                    }
                }
            }

            // 3번 검사하기
            if (Is_Order_02 == false)
            {
                if (Is_Order_03 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_03.Inventory_Sprite.spriteName == "J_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_03.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_03.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_03.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_H);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_H);

                            // 안보이게 하기 
                            if (Inventory_Controller_03.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_03.Inventory_Panel.alpha = 0f;
                                Inventory_Controller_03.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    //물건이 없는 경우  
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "J_03_Idle_01")
                    {
                        Is_Order_03 = false;
                        Is_Order_04 = true;
                    }
                }
            }

            // 4번 검사하기 
            if (Is_Order_03 == false)
            {
                if (Is_Order_04 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_04.Inventory_Sprite.spriteName == "J_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_04.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_04.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_04.Check_Count_Cha();

                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_H);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_H);

                            // 안보이게 하기 
                            if (Inventory_Controller_04.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_04.Inventory_Panel.alpha = 0f;

                                Inventory_Controller_04.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "J_03_Idle_01")
                    {
                        Is_Order_04 = false;
                        Is_Order_05 = true;
                    }
                }
            }

            // 5번 검사하기
            if (Is_Order_04 == false)
            {
                if (Is_Order_05 == true)
                {
                    // 물건이 있는 경우                                   
                    if (Inventory_Controller_05.Inventory_Sprite.spriteName == "J_03_Idle_01")
                    {
                        // 납품 성공 
                        if (Inventory_Controller_05.Cha_Count_In_Inventory >= 1)
                        {
                            // 숫자 감소
                            Inventory_Controller_05.Cha_Count_In_Inventory -= 1;
                            Inventory_Controller_05.Check_Count_Cha();
                      
                            // 성공 여부 알려주기 
                            Quest_01.Food_Fin_01 = true;
                            Quest_02.Food_Fin_02 = true;
                            Quest_03.Food_Fin_03 = true;
                            Quest_04.Food_Fin_04 = true;

                            // 영수증에 보여줄 숫자 
                            Count_Order++;

                            // 성공에 대한 보상을 얻어야 한다. 
                            Player_Happy_Man_Script.Player_Happy_Go_Up(Player_Get_Happy_H);
                            Status_Man_Script.Player_Coin(Player_Get_Coin_H);

                            // 안보이게 하기 
                            if (Inventory_Controller_05.Cha_Count_In_Inventory <= 0)
                            {
                                Inventory_Controller_05.Inventory_Panel.alpha = 0f;

                                Inventory_Controller_05.Inventory_Sprite.spriteName = "None";
                            }
                        }
                    }

                    // 물건이 없는 경우 
                    else if (Inventory_Controller_03.Inventory_Sprite.spriteName != "J_03_Idle_01")
                    {
                        Is_Order_05 = false;
                        Is_Order_06 = true;
                    }
                }
            }
        }

        // 체크값 초기화
        Re_Set_Bool();
    }





    public void Inven_Out_Button()
    {
        if (IS_Inven_On == true)
        {
            Sound_Man_Script.Play_Button_Click();
            IS_Inven_On = false;
            Inventory_Panel.alpha = 0f;
        }
    }


    // 감소하기 
    ///////////////////////////////////////////////////////
    public void IS_Inventory_Controller_01_Fin_C()
    {
        Inventory_Controller_01.Cha_Count_In_Inventory -= 1;
        Inventory_Controller_01.Check_Count_Cha();

        // 안보이게 하기 
        if (Inventory_Controller_01.Cha_Count_In_Inventory <= 0)
        {
            Inventory_Controller_01.Inventory_Panel.alpha = 0f;
            Inventory_Controller_01.Inventory_Sprite.spriteName = "None";
        }
    }
    public void IS_Inventory_Controller_02_Fin_C()
    {
        // 숫자 감소
        Inventory_Controller_02.Cha_Count_In_Inventory -= 1;
        Inventory_Controller_02.Check_Count_Cha();

        // 안보이게 하기 
        if (Inventory_Controller_02.Cha_Count_In_Inventory <= 0)
        {
            Inventory_Controller_02.Inventory_Panel.alpha = 0f;
            Inventory_Controller_02.Inventory_Sprite.spriteName = "None";
        }
    }
    public void IS_Inventory_Controller_03_Fin_C()
    {
        // 숫자 감소
        Inventory_Controller_03.Cha_Count_In_Inventory -= 1;
        Inventory_Controller_03.Check_Count_Cha();

        // 안보이게 하기 
        if (Inventory_Controller_03.Cha_Count_In_Inventory <= 0)
        {
            Inventory_Controller_03.Inventory_Panel.alpha = 0f;
            Inventory_Controller_03.Inventory_Sprite.spriteName = "None";
        }
    }
    public void IS_Inventory_Controller_04_Fin_C()
    {
        // 숫자 감소
        Inventory_Controller_04.Cha_Count_In_Inventory -= 1;
        Inventory_Controller_04.Check_Count_Cha();

        // 안보이게 하기 
        if (Inventory_Controller_04.Cha_Count_In_Inventory <= 0)
        {
            Inventory_Controller_04.Inventory_Panel.alpha = 0f;
            Inventory_Controller_04.Inventory_Sprite.spriteName = "None";
        }
    }
    public void IS_Inventory_Controller_05_Fin_C()
    {
        // 숫자 감소
        Inventory_Controller_05.Cha_Count_In_Inventory -= 1;
        Inventory_Controller_05.Check_Count_Cha();

        // 안보이게 하기 
        if (Inventory_Controller_05.Cha_Count_In_Inventory <= 0)
        {
            Inventory_Controller_05.Inventory_Panel.alpha = 0f;
            Inventory_Controller_05.Inventory_Sprite.spriteName = "None";
        }
    }


    //증가하기  
    ///////////////////////////////////////////////////////
    public void Give_Back_01_Fin_C()
    {
        // 숫자 증가 
        Inventory_Controller_01.Cha_Count_In_Inventory += 1;
        Inventory_Controller_01.Check_Count_Cha();

        // 보이게 하기 
        if (Inventory_Controller_01.Cha_Count_In_Inventory >= 0)
        {
            Inventory_Controller_01.Inventory_Panel.alpha = 1f;
        }
    }
    public void Give_Back_02_Fin_C()
    {
        Debug.Log("성공");
        // 숫자 증가 
        Inventory_Controller_02.Cha_Count_In_Inventory += 1;
        Inventory_Controller_02.Check_Count_Cha();

        // 보이게 하기 
        if (Inventory_Controller_02.Cha_Count_In_Inventory >= 0)
        {
            Inventory_Controller_02.Inventory_Panel.alpha = 1f;
        }
    }
    public void Give_Back_03_Fin_C()
    {
        // 숫자 증가 
        Inventory_Controller_03.Cha_Count_In_Inventory += 1;
        Inventory_Controller_03.Check_Count_Cha();

        // 보이게 하기 
        if (Inventory_Controller_03.Cha_Count_In_Inventory >= 0)
        {
            Inventory_Controller_03.Inventory_Panel.alpha = 1f;
        }
    }
    public void Give_Back_04_Fin_C()
    {
        // 숫자 증가 
        Inventory_Controller_04.Cha_Count_In_Inventory += 1;
        Inventory_Controller_04.Check_Count_Cha();

        // 보이게 하기 
        if (Inventory_Controller_04.Cha_Count_In_Inventory >= 0)
        {
            Inventory_Controller_04.Inventory_Panel.alpha = 1f;
        }
    }
    public void Give_Back_05_Fin_C()
    {
        // 숫자 증가 
        Inventory_Controller_05.Cha_Count_In_Inventory += 1;
        Inventory_Controller_05.Check_Count_Cha();

        // 보이게 하기 
        if (Inventory_Controller_05.Cha_Count_In_Inventory >= 0)
        {
            Inventory_Controller_05.Inventory_Panel.alpha = 1f;
        }
    }



    // i 누르면 창 나오게 하기
    void Update () {
        // i 눌르면 창 나오게 하기 
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (IS_Inven_On == false)
            {
                IS_Inven_On = true;
                Inventory_Panel.alpha = 1f;

                Sound_Man_Script.Play_Scene_Change();
            }
            else if (IS_Inven_On == true)
            {
                IS_Inven_On = false;
                Inventory_Panel.alpha = 0f;

                Sound_Man_Script.Play_Scene_Change();
            }
        }          
        }   
}
