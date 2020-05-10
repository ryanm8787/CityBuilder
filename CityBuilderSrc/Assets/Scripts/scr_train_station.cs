using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * To make a create station system we need the following
 * 1. A button
 * 2. A cursor object snapped to a grid 
 * 3. An object itself when it's created (we currently have)
 */

public class scr_train_station : MonoBehaviour
{
    private bool is_connected;
    public string station_name;
    private List<string> connected_stations;
    private bool selected = false;
    private bool is_mouse_in = false;

    private void Start()
    {
        connected_stations = new List<string>();
    }

    void OnMouseOver()
    {
        is_mouse_in = true;
        if (Input.GetMouseButtonDown(0))
        {
            if (!selected)
            {
                scr_UI_handler.CURRENT_UI = scr_UI_handler.UIType.TRAIN;
                selected = true;
                print_details();
            }
            else
            {
                scr_UI_handler.CURRENT_UI = scr_UI_handler.UIType.DEFAULT;
                selected = false;
            }
        }
    }

    void OnMouseExit()
    {
        is_mouse_in = false;    
    }

    void print_details()
    {
        Debug.Log("Name: " + station_name);
        Debug.Log("Connected: " + is_connected);
        
        Debug.Log("Connected Stations:");

        if (connected_stations.Count > 0)
        {
            foreach (string s in connected_stations)
            {
                Debug.Log(s);
            }
        }
        else
        {
            Debug.Log("None");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(scr_UI_handler.CURRENT_UI);
        if(!is_mouse_in)
        {
            if (Input.GetMouseButtonDown(0))
            { 
                if(selected)
                {
                    selected = false;
                    scr_UI_handler.CURRENT_UI = scr_UI_handler.UIType.DEFAULT;
                }
            }
        }
    }
}
