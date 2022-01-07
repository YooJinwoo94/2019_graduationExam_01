using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash_Cha_Con_01 : MonoBehaviour {


    public UISprite Trash_Cha_Sprite;

    public float moveSpeed; //이동속도 

    public bool Trash_Cha_Move;
    public bool is_Move_Left;
    public bool Left;
    public bool Right;






    private void Awake()
    {
        Right = true;
    }

    public void Turn_On_Move()
    {      
        StartCoroutine("Move_Cha");
    }

  
    IEnumerator Move_Cha()
    {
       if (Trash_Cha_Move == true)
        {

            if (Right == true )
            {
                Trash_Cha_Sprite.flip = UIBasicSprite.Flip.Horizontally;

                GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y) ;
                Debug.Log("a");

               if(transform.position.x > 1.4f)
                 {
                    Right = false;
                    Left = true;
                    Debug.Log("bbbbbbbbbbbbbbbbbbf");
                }
            }

             if ( Left == true)
            {
                Trash_Cha_Sprite.flip = UIBasicSprite.Flip.Nothing;

                GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y) ;
                Debug.Log("a");

                if (transform.position.x <-1.4)
                {
                    Right = true;
                    Left = false;
                    Debug.Log("bbbbbbbbbbbbbbbbbbf");
                }
            }
        }

        else if (Trash_Cha_Move == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
      
            yield break;
        }
        yield return null;
        StartCoroutine("Move_Cha");
    }
}
