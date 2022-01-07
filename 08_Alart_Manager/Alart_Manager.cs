using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alart_Manager : MonoBehaviour {

    public GameObject UI_Alart;

    public Sound_Manager Sound_Man_Script;

    UILabel Content_Label;

    Vector3 Origin_Pos;
    Vector3 Next_Pos;

    string Alart_Content;


    private void Awake()
    {
        Content_Label = UI_Alart.GetComponentInChildren<UILabel>();

        Origin_Pos = UI_Alart.transform.position;
        Next_Pos = UI_Alart.transform.position;

        Next_Pos.x = 0f;
    }

    public void Set_Alart (string value)
    {
        Alart_Content = value;
        Content_Label.text = Alart_Content;

        UI_Alart.transform.position = Origin_Pos;

        Sound_Man_Script.Play_Alarm_Sound();

        StopCoroutine("Up_Panel");
        StopCoroutine("Down_Panel");

        StartCoroutine("Down_Panel");
    }




    IEnumerator Down_Panel()
    {
        yield return null;

        UI_Alart.transform.position = Vector3.Lerp(UI_Alart.transform.position, Next_Pos, 0.1f);

      if(UI_Alart.transform.position.x <= Next_Pos.x + 0.06f)
        {
            yield return new WaitForSeconds(1.5f);

            StartCoroutine("Up_Panel");
            StopCoroutine("Down_Panel");

            yield break;
        }
      else
        {
            StartCoroutine("Down_Panel");
        }
    }


    IEnumerator Up_Panel()
    {
        yield return null;

        UI_Alart.transform.position = Vector3.Lerp(UI_Alart.transform.position, Origin_Pos, 0.1f);

        if (UI_Alart.transform.position.x >= Next_Pos.x + 0.05f)
        {
            UI_Alart.transform.position = Origin_Pos;
            yield return new WaitForSeconds(1.5f);
            
            StopCoroutine("Up_Panel");

            yield break;
        }
        else
        {
            StartCoroutine("Up_Panel");
        }
    }
}
