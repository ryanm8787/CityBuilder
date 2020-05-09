using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_train_station : MonoBehaviour
{
    private bool is_connected;
    public string station_name;
    private List<string> connected_stations;

    private void Start()
    {
        connected_stations = new List<string>();
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print_details();
        }
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
        else;
        {
            Debug.Log("None");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
