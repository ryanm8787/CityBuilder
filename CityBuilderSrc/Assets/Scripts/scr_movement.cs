using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_movement : MonoBehaviour
{
    public float camera_speed;
    public float pan_speed;
    public float border_thickness;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.mousePosition.y >= (Screen.height - border_thickness))
        {
            move_up();
        }
        else if (Input.GetKey(KeyCode.S) || Input.mousePosition.y <= border_thickness)
        {
            move_down();
        }
        else if (Input.GetKey(KeyCode.D) || Input.mousePosition.x >= (Screen.width - border_thickness))
        {
            move_right();    
        }
        else if (Input.GetKey(KeyCode.A) || Input.mousePosition.x <= border_thickness)
        {
            move_left();
        }
    }

    private void move_up()
    {
        Vector3 new_pos =transform.position;
        new_pos.y += camera_speed * Time.deltaTime;
        transform.position = new_pos;
    }

    private void move_down()
    {
        Vector3 new_pos = transform.position;
        new_pos.y -= camera_speed * Time.deltaTime;
        transform.position = new_pos;
    }

    private void move_right()
    {
        Vector3 new_pos = transform.position;
        new_pos.x += camera_speed * Time.deltaTime;
        transform.position = new_pos;
    }
    private void move_left()
    {
        Vector3 new_pos = transform.position;
        new_pos.x -= camera_speed * Time.deltaTime;
        transform.position = new_pos;
    }
}
