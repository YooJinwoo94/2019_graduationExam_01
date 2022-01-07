using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Happy_Manager : MonoBehaviour {

    public UILabel Player_Happy_Count;

    private int Player_Happy_Point;
    int Time_Flow_Counter;
    float x = 5;


    private void Awake()
    {
       Player_Happy_Point = 0;
    }

    public void Player_Happy_Go_Up(int x)
    {
        Player_Happy_Point += x;
        Player_Happy_Count.text = string.Format("{0:n0}", Player_Happy_Point);

        StartCoroutine("Money_Up");
    }

    IEnumerator Money_Up()
    {
        if (Time_Flow_Counter >= 10)
        {
            x = 0.05f;
            Player_Happy_Count.fontSize = 60;
            Player_Happy_Count.fontSize--;

        }

        if (Time_Flow_Counter <= 4)
        {
            x = 0.001f;
            Player_Happy_Count.fontSize--;
        }

        Player_Happy_Count.fontSize--;


        if (Player_Happy_Count.fontSize <= 40)
        {
            Player_Happy_Count.fontSize = 40;
            Time_Flow_Counter = 10;
            yield break;
        }

        Time_Flow_Counter--;
        yield return new WaitForSeconds(x);
        StartCoroutine("Money_Up");
    }

}
