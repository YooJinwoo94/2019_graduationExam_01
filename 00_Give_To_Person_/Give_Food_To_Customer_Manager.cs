using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public enum Food_Recipe_Type
{
    Food_01 = 1,
    Food_02,
    Food_03,
    Food_04,
    Food_05,
    Food_06,
    Food_07,
    Food_08,
}





public class Give_Food_To_Customer_Manager : MonoBehaviour {


    public Give_Food_To_Customer_Controller_01 Food_Controller_01;
    public Give_Food_To_Customer_Controller_02 Food_Controller_02;
    public Give_Food_To_Customer_Controller_03 Food_Controller_03;
    public Give_Food_To_Customer_Controller_04 Food_Controller_04;

    public Food_Recipe_Type _Type_Of_Recipe;





    //음식의 종류는 9개
    public bool Food_A;
    public bool Food_B;
    public bool Food_C;
    public bool Food_D;
    public bool Food_E;
    public bool Food_F;
    public bool Food_G;
    public bool Food_H;
    public bool Food_I;


    public int A;
    public int B;
    public int C;
    public int D;
    public int E;
    public int F;
    public int G;
    public int H;
    public int I;



    //양파 
    public int Need_Count_01;
    //양상추
    public int Need_Count_02;
    //토마토
    public int Need_Count_03;
    //고기
    public int Need_Count_04;
    //치킨
    public int Need_Count_05;
    //오징어
    public int Need_Count_06;
    //새우
    public int Need_Count_07;
    //생선
    public int Need_Count_08;
    //오일
    public int Need_Count_09;
    //조미료
    public int Need_Count_10;







    // 레시피에 들어가는 음식의 종류 및 개수 체크
    public void Recipe_Check()
     {
        // 양파만 
        if (Food_A == true)
        {
            Need_Count_01 = 1;
            Need_Count_02 = 0;
            Need_Count_03 = 0;
            Need_Count_04 = 0;
            Need_Count_05 = 0;
            Need_Count_06 = 0;
            Need_Count_07 = 0;
            Need_Count_09 = 0;
            Need_Count_10 = 0;
        }

        //  양상추만 
        else if (Food_B == true)
        {
            Need_Count_01 = 0;
            Need_Count_02 = 1;
            Need_Count_03 = 0;
            Need_Count_04 = 0;
            Need_Count_05 = 0;
            Need_Count_06 = 0;
            Need_Count_07 = 0;
            Need_Count_09 = 0;
            Need_Count_10 = 0;
        }

        // 양상추+양파 
        else if (Food_C == true)
        {
            Need_Count_01 = 1;
            Need_Count_02 = 1;
            Need_Count_03 = 0;
            Need_Count_04 = 0;
            Need_Count_05 = 0;
            Need_Count_06 = 0;
            Need_Count_07 = 0;
            Need_Count_09 = 0;
            Need_Count_10 = 0;
        }

        // 고기
        else if (Food_D == true)
        {
            Need_Count_01 = 0;
            Need_Count_02 = 0;
            Need_Count_03 = 0;
            Need_Count_04 = 1;
            Need_Count_05 = 0;
            Need_Count_06 = 0;
            Need_Count_07 = 0;
            Need_Count_09 = 0;
            Need_Count_10 = 0;
        }

        // 치킨
        else if (Food_E == true)
        {
            Need_Count_01 = 0;
            Need_Count_02 = 0;
            Need_Count_03 = 0;
            Need_Count_04 = 0;
            Need_Count_05 = 1;
            Need_Count_06 = 0;
            Need_Count_07 = 0;
            Need_Count_09 = 0;
            Need_Count_10 = 0;
        }

        // 새우 
        else if (Food_F == true)
        {
            Need_Count_01 = 0;
            Need_Count_02 = 0;
            Need_Count_03 = 0;
            Need_Count_04 = 0;
            Need_Count_05 = 0;
            Need_Count_06 = 0;
            Need_Count_07 = 1;
            Need_Count_09 = 0;
            Need_Count_10 = 0;
        }

        // 조미료 
        else if (Food_G == true)
        {
            Need_Count_01 = 0;
            Need_Count_02 = 0;
            Need_Count_03 = 0;
            Need_Count_04 = 0;
            Need_Count_05 = 0;
            Need_Count_06 = 0;
            Need_Count_07 = 0;
            Need_Count_09 = 1;
            Need_Count_10 = 0;
        }

        // 토마토 
        else if (Food_H == true)
        {
            Need_Count_01 = 0;
            Need_Count_02 = 0;
            Need_Count_03 = 1;
            Need_Count_04 = 0;
            Need_Count_05 = 0;
            Need_Count_06 = 0;
            Need_Count_07 = 0;
            Need_Count_09 = 0;
            Need_Count_10 = 0;
        }
    }




    // 요리의 타입 체크 
    // 1번 퀘스트창
    public void Check_Type_01()
    {
        Debug.Log("Check");
        // 레시피 1호의 이름 체크 
        if (Food_Controller_01.Food_Sprite.spriteName == "A_1")
        {
            Debug.Log("Check_1");
            _Type_Of_Recipe = Food_Recipe_Type.Food_01;

            Food_A = true;

            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_01.Food_Sprite.spriteName == "A_2")
        {
            Debug.Log("Check_2");
            _Type_Of_Recipe = Food_Recipe_Type.Food_02;

            Food_A = false;

            Food_B = true;

            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_01.Food_Sprite.spriteName == "A_3")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_03;

            Food_A = false;
            Food_B = false;

            Food_C = true;

            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_01.Food_Sprite.spriteName == "A_4")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_04;

            Food_A = false;
            Food_B = false;
            Food_C = false;

            Food_D = true;

            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_01.Food_Sprite.spriteName == "A_5")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_05;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;

            Food_E = true;

            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_01.Food_Sprite.spriteName == "A_6")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_06;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;

            Food_F = true;

            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_01.Food_Sprite.spriteName == "A_7")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_07;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;

            Food_G = true;

            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_01.Food_Sprite.spriteName == "A_8")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_08;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;

            Food_H = true;

            Food_I = false;
        }
    }
    // 2번 퀘스트창
    public void Check_Type_02()
    {
        Debug.Log("Check");
        // 레시피 2호의 이름 체크 
        if (Food_Controller_02.Food_Sprite.spriteName == "A_1")
        {
            Debug.Log("Check_1");
            _Type_Of_Recipe = Food_Recipe_Type.Food_01;

            Food_A = true;

            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_02.Food_Sprite.spriteName == "A_2")
        {
            Debug.Log("Check_2");
            _Type_Of_Recipe = Food_Recipe_Type.Food_02;

            Food_A = false;

            Food_B = true;

            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_02.Food_Sprite.spriteName == "A_3")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_03;

            Food_A = false;
            Food_B = false;

            Food_C = true;

            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_02.Food_Sprite.spriteName == "A_4")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_04;

            Food_A = false;
            Food_B = false;
            Food_C = false;

            Food_D = true;

            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_02.Food_Sprite.spriteName == "A_5")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_05;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;

            Food_E = true;

            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_02.Food_Sprite.spriteName == "A_6")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_06;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;

            Food_F = true;

            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_02.Food_Sprite.spriteName == "A_7")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_07;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;

            Food_G = true;

            Food_H = false;
            Food_I = false;
        }
      
        else if (Food_Controller_02.Food_Sprite.spriteName == "A_8")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_08;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;

            Food_H = true;

            Food_I = false;
        }
    }
    // 3번 퀘스트창
    public void Check_Type_03()
    {
        Debug.Log("Check");
        // 레시피 3호의 이름 체크
        if (Food_Controller_03.Food_Sprite.spriteName == "A_1")
        {
            Debug.Log("Check_1");
            _Type_Of_Recipe = Food_Recipe_Type.Food_01;

            Food_A = true;

            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_03.Food_Sprite.spriteName == "A_2")
        {
            Debug.Log("Check_2");
            _Type_Of_Recipe = Food_Recipe_Type.Food_02;

            Food_A = false;

            Food_B = true;

            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_03.Food_Sprite.spriteName == "A_3")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_03;

            Food_A = false;
            Food_B = false;

            Food_C = true;

            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_03.Food_Sprite.spriteName == "A_4")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_04;

            Food_A = false;
            Food_B = false;
            Food_C = false;

            Food_D = true;

            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_03.Food_Sprite.spriteName == "A_5")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_05;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;

            Food_E = true;

            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_03.Food_Sprite.spriteName == "A_6")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_06;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;

            Food_F = true;

            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_03.Food_Sprite.spriteName == "A_7")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_07;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;

            Food_G = true;

            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_03.Food_Sprite.spriteName == "A_8")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_08;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;

            Food_H = true;

            Food_I = false;
        }
    }
    // 4번 퀘스트창
    public void Check_Type_04()
    {
        Debug.Log("Check");
        // 레시피 4호의 이름 체크 
        if (Food_Controller_04.Food_Sprite.spriteName == "A_1")
        {
            Debug.Log("Check_1");
            _Type_Of_Recipe = Food_Recipe_Type.Food_01;

            Food_A = true;

            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_04.Food_Sprite.spriteName == "A_2")
        {
            Debug.Log("Check_2");
            _Type_Of_Recipe = Food_Recipe_Type.Food_02;

            Food_A = false;

            Food_B = true;

            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_04.Food_Sprite.spriteName == "A_3")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_03;

            Food_A = false;
            Food_B = false;

            Food_C = true;

            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_04.Food_Sprite.spriteName == "A_4")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_04;

            Food_A = false;
            Food_B = false;
            Food_C = false;

            Food_D = true;

            Food_E = false;
            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_04.Food_Sprite.spriteName == "A_5")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_05;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;

            Food_E = true;

            Food_F = false;
            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_04.Food_Sprite.spriteName == "A_6")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_06;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;

            Food_F = true;

            Food_G = false;
            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_04.Food_Sprite.spriteName == "A_7")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_07;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;

            Food_G = true;

            Food_H = false;
            Food_I = false;
        }

        else if (Food_Controller_04.Food_Sprite.spriteName == "A_8")
        {
            _Type_Of_Recipe = Food_Recipe_Type.Food_08;

            Food_A = false;
            Food_B = false;
            Food_C = false;
            Food_D = false;
            Food_E = false;
            Food_F = false;
            Food_G = false;

            Food_H = true;

            Food_I = false;
        }
    }
}
