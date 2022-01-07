using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status_Manager : MonoBehaviour {

	public UILabel Money_Label;
    public UILabel Player_Happy_Label;

    public static int Money;
    int Time_Flow_Counter;
    float x = 5;


    private void Awake()
    {
        Time_Flow_Counter = 10;
        Money = 900000;
        StartCoroutine("Status_Update");
    }


    IEnumerator Status_Update()
    {
        yield return new WaitForSeconds(0.1f);

        Money_Label.text = string.Format("{0:n0}", Money);

        StartCoroutine("Status_Update");
    }


    IEnumerator Money_Up()
    {
        if (Time_Flow_Counter >= 10)
        {
            x = 0.05f;
            Money_Label.fontSize = 50;
            Money_Label.fontSize--;

        }
     
        if (Time_Flow_Counter <= 4)
        {
            x = 0.001f;
            Money_Label.fontSize--;
        }

        Money_Label.fontSize--;


        if (Money_Label.fontSize <= 30)
        {
            Money_Label.fontSize = 30;
            Time_Flow_Counter = 10;
            yield break;
        }

        Time_Flow_Counter--;
        yield return new WaitForSeconds(x);
        StartCoroutine("Money_Up");
    }

    public void Player_Coin(int x)
    {
        StartCoroutine("Money_Up");
        Money += x;
        Money_Label.text = string.Format("{0:n0}", Money);
    }
}
