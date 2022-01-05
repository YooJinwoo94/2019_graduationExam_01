using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Give_Food_To_Customer_Controller_01 : MonoBehaviour {

    public ParticleSystem Particle_;

    public Main_Cam _Main_Cam_Script;
    public Player_Happy_Manager Player_Happy_Man_Script;
    public Give_Food_To_Customer_Manager _Give_Food_To_Customer_Man;
    public Alart_Manager _Alart_Manager_Script;
    public Inventory_Manager _Inven_Man;
    public Sound_Manager Sound_Man_Script;
    public Order_Food_Manager Order_Food_Man_Script;

    public UIPanel Order_Panel_01;
    /// <summary>
    /// //////////////////////////////////////
    /// </summary>
    public UIPanel Detail_Order_Panel_01;

    public UISprite Food_Sprite;

    public UISprite Need_Sprite_01;
    public UISprite Need_Sprite_02;
    public UISprite Need_Sprite_03;

    public bool Food_Fin_01;

    

        
    // 성공 실패 값 확인 
    public void Check_Food_Check_01()
    {
        //성공
        if(Food_Fin_01 == true)
        {
            Sound_Man_Script.Play_Delivery_Sound();
            //성공 알람창 뜨기 
            _Alart_Manager_Script.Set_Alart("[8ACE19]납품[-]을 [ff0000]완료[-]하였습니다.");

            // 해당 panel 알파값 조절
            Order_Panel_01.alpha = 0;
            Detail_Order_Panel_01.alpha = 0;

            // 화면 전환 되게 하기
            _Main_Cam_Script.Is_Cam_Stop = false;

            Order_Food_Man_Script.Payed_01 = true;

            Particle_.Play();
        }

        //실패
        else if (Food_Fin_01 == false)
        {
            Sound_Man_Script.Play_Delivery_Fail_Sound();
            //실패 알람창 뜨기
            _Alart_Manager_Script.Set_Alart("[8ACE19]물품[-]이 [ff0000]부족[-]합니다.");
        }
    }



    
   


	// 버튼 클릭 내가 가지고 있는 퀘스트의 특징 +  인벤토리에 물건이 있는지 확인 
    public void Check_IS_Food_Finished_01 ()
    {
        // 첫번째 래시피의 요리 타입을 검색한다.
        _Give_Food_To_Customer_Man.Check_Type_01();

        // 해당 요리에 필요한 재료의 종류 및 개수를 검색한다.
        _Give_Food_To_Customer_Man.Recipe_Check();




        // 요리가 A ?
        if (_Give_Food_To_Customer_Man.Food_A == true)
        {
            _Inven_Man.Check_Order_To_Inven();
        }
        // 요리가 B ?
        else if (_Give_Food_To_Customer_Man.Food_B == true)
        {
            _Inven_Man.Check_Order_To_Inven();
        }
        // 요리가 C ?
        else if (_Give_Food_To_Customer_Man.Food_C == true)
        {
            _Inven_Man.Check_Order_To_Inven();
        }
        // 요리가 D ?
        else if (_Give_Food_To_Customer_Man.Food_D == true)
        {
            _Inven_Man.Check_Order_To_Inven();
        }
        // 요리가 E ?
        else if (_Give_Food_To_Customer_Man.Food_E == true)
        {
            _Inven_Man.Check_Order_To_Inven();
        }
        // 요리가 F ?
        else if (_Give_Food_To_Customer_Man.Food_F == true)
        {
            _Inven_Man.Check_Order_To_Inven();
        }
        // 요리가 G ?
        else if (_Give_Food_To_Customer_Man.Food_G == true)
        {
            _Inven_Man.Check_Order_To_Inven();
        }
        // 요리가 H ?
        else if (_Give_Food_To_Customer_Man.Food_H == true)
        {
            _Inven_Man.Check_Order_To_Inven();
        }
        // 요리가 I ?
        else if (_Give_Food_To_Customer_Man.Food_I == true)
        {
            _Inven_Man.Check_Order_To_Inven();
        }

        Check_Food_Check_01();

        _Inven_Man.Quest_01.Food_Fin_01 = false;
        _Inven_Man.Quest_02.Food_Fin_02 = false;
        _Inven_Man.Quest_03.Food_Fin_03 = false;
        _Inven_Man.Quest_04.Food_Fin_04 = false;
    }
}
