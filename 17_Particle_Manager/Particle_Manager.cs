using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Manager : MonoBehaviour {

    public ParticleSystem[] Do_Not_Like;
    public ParticleSystem[] Normal_Heart;
    public ParticleSystem[] Hard_Love;

    public ParticleSystem[] Debuff_Cha;

    public ParticleSystem[] Gone_Particle;

    public ParticleSystem[] Full_Level_Up_Particle;

    public GameObject[] Make_Enabled_Particle;



    public void Particle_Debuff_Cha_On(int i )
    {
        Debug.Log("AA");
      
       Debuff_Cha[i].Play(true);
    }

    public void Particle_Debuff_Cha_Off(int i)
    {
        Debuff_Cha[i].Stop(true);      
    }
}
