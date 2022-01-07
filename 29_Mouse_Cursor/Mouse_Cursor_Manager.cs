using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Cursor_Manager : MonoBehaviour {

    public UISprite Mouse;

    public GameObject clickEffect;

    public Camera Cam;

    public ParticleSystem Click;

    private void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update () {
        Vector2 cursprPos = Cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursprPos;

        if (Input.GetMouseButtonDown(0))
        {
            Mouse.spriteName = "Mouse_Click";
           
            Click.Play();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Mouse.spriteName = "Mouse_Idle";
        }
	}
}
