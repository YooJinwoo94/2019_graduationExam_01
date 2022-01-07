using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Manager : MonoBehaviour {

    
    public static int Time_Flow_Counter;

    public Order_Food_Manager Order_Food_Man_Script;

    private int Phase_Of_Order = 30 ;

    int First_Count;
    bool First;

    private void Awake()
    {
        First_Count = 0;
        First = false;

        Time_Flow_Counter = 0;

        StartCoroutine("Make_Order_Time_Flow");
    }




    IEnumerator Make_Order_Time_Flow()
    {
        if (Order_Food_Man_Script.Order_01_Panel.alpha == 0f || Order_Food_Man_Script.Order_02_Panel.alpha == 0f ||
               Order_Food_Man_Script.Order_03_Panel.alpha == 0f || Order_Food_Man_Script.Order_04_Panel.alpha == 0f)
        {
            if (First == false && First_Count == 5)
            {
                First = true;
                Order_Food_Man_Script.Make_Order();
            }
        }
            

        // 지정된 시간이 됬을 경우
        if (Time_Flow_Counter == Phase_Of_Order)
        {
            Time_Flow_Counter = 0;

            if (Order_Food_Man_Script.Order_01_Panel.alpha == 0f || Order_Food_Man_Script.Order_02_Panel.alpha == 0f ||
                 Order_Food_Man_Script.Order_03_Panel.alpha == 0f || Order_Food_Man_Script.Order_04_Panel.alpha == 0f)
            {
                // 주문하기 
                Order_Food_Man_Script.Make_Order();
                Debug.Log("생성");
               // yield break;
            }
        }
        First_Count++;
        Time_Flow_Counter++;

        yield return new WaitForSeconds(1f);
        StartCoroutine("Make_Order_Time_Flow");
    }
}
