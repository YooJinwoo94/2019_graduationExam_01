using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Cam : MonoBehaviour {


    public bool Is_Cam_Stop;
    public float pan_Speed = 1000f;
    public float pan_Border_Thickness = 10f;
    public Vector2 pan_Limit;
    public Vector2 Up_Down;

    public Camera Cam;



    private void Update()
    {      

        if (Is_Cam_Stop == false)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                Cam.orthographicSize = 0.4f;

            }

            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                Cam.orthographicSize = 1;

            }

            if (Cam.orthographicSize >= 1)

            {
                Vector3 pos = transform.localPosition;

                pan_Limit.x = 0;
                pan_Limit.y = 2963;

                if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - pan_Border_Thickness)
                {
                    pos.y += pan_Speed * Time.deltaTime;
                }

                else if (Input.GetKey("s") || Input.mousePosition.y <= pan_Border_Thickness)
                {
                    pos.y -= pan_Speed * Time.deltaTime;
                }
                /*
                else if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - pan_Border_Thickness)
                {
                    pos.x += pan_Speed * Time.deltaTime;
                }

                else if (Input.GetKey("a") || Input.mousePosition.x <= pan_Border_Thickness)
                {
                    pos.x -= pan_Speed * Time.deltaTime;
                }
                */
                pos.x = 4;
                pos.y = Mathf.Clamp(pos.y, -pan_Limit.y, -6);


                /*
                if (Input.mousePosition.x <= 2000 && Input.mousePosition.x <= 1000)
                {
                    transform.localPosition = Input.mousePosition;
                }
                */

                transform.localPosition = pos;
            }


            else if (Cam.orthographicSize <= 1)
            {
                if (Input.GetAxis("Mouse ScrollWheel") > 0)
                {
                    Cam.orthographicSize = 0.6f;

                }

                if (Input.GetAxis("Mouse ScrollWheel") < 0)
                {
                    Cam.orthographicSize = 1;

                }


                Vector3 pos = transform.localPosition;
                pan_Limit.x = 376;
                pan_Limit.y = 3164;
                int Sceen_Height_y = 215;


                {
                    if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - pan_Border_Thickness)
                    {
                        pos.y += pan_Speed * Time.deltaTime;
                    }

                    else if (Input.GetKey("s") || Input.mousePosition.y <= pan_Border_Thickness)
                    {
                        pos.y -= pan_Speed * Time.deltaTime;
                    }

                    else if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - pan_Border_Thickness)
                    {
                        pos.x += pan_Speed * Time.deltaTime;
                    }

                    else if (Input.GetKey("a") || Input.mousePosition.x <= pan_Border_Thickness)
                    {
                        pos.x -= pan_Speed * Time.deltaTime;
                    }



                    pos.x = Mathf.Clamp(pos.x, -pan_Limit.x, pan_Limit.x);
                    pos.y = Mathf.Clamp(pos.y, -pan_Limit.y, Sceen_Height_y);

                    //transform.position = Cam.ScreenToWorldPoint(pos);
                    transform.localPosition = pos;
                }
            }
        }
    }






    public void Up_Button()
    {
        Vector3 pos = transform.localPosition;
        pos.y = -6;

        transform.localPosition = pos;
    }

    public void Down_Button()
    {
        Vector3 pos = transform.localPosition;
        pos.y = -2963 ;

        transform.localPosition = pos;
    }
}
