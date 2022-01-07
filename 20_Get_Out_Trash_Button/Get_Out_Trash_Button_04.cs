using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Out_Trash_Button_04 : MonoBehaviour {

    public Sound_Manager Sound_Man_Script;
    public Get_Out_Trash_Cha_Manager Get_Out_Trash_Cha_Man_Script;
    public Fridge_Manager Fridge_Man_Script;
    public ParticleSystem Dust;

    public UISpriteAnimation UI_Sprite_Ani;

    public UIPanel Get_Out_Button_Panel;
    public UIPanel Trash_Cha_Panel;
    public UIPanel[] Trash_Cha_Panel_;

    public BoxCollider Trash_Cha_Click_Collider;


    public void Is_Fridge_Button_Click()
    {
        //파티클 발동
        Dust.Play(true);

        Get_Out_Trash_Cha_Man_Script.Debuff_Particle_Off_04();

        //애니메이션 비활성화
        UI_Sprite_Ani.enabled = false;
        //  냉동고에 보내기 
        Fridge_Man_Script.Check_Panel_On_Off();

        // 사라짐
        Trash_Cha_Panel.alpha = 0f;
        // 쓰레기 캐릭터의 충돌박스 비활성화 
        Trash_Cha_Click_Collider.enabled = false;

        Get_Out_Button_Panel.alpha = 0f;

        //============================================================================================================================================= 쓰레기 애들이 1개라도 없으면
        if (Trash_Cha_Panel_[0].alpha == 0f && Trash_Cha_Panel_[1].alpha == 0f && Trash_Cha_Panel_[2].alpha == 0f && Trash_Cha_Panel_[3].alpha == 0f)
        {
            // 사운드 
            Sound_Man_Script.Is_Debuff_Sound = false;
            Sound_Man_Script.Stop_Escape_Sound();
        }
    }
}
