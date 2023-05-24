using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tab_controller : MonoBehaviour
{
    Vector2 mousePosBegan, mousePosEnded, windowBegan, windowEnded;
    [SerializeField] windows_manager windows;
    [SerializeField] GameObject window;
    bool tabLock = false;
    void Update()
    {
        if (Input.GetMouseButton(0) && tabLock == true)
        {
            mousePosEnded = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x - mousePosBegan.x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y - mousePosBegan.y);
            windowEnded = new Vector3(windowBegan.x + mousePosEnded.x, windowBegan.y + mousePosEnded.y);
            window.transform.position = windowEnded;
        }
        else
            tabLock = false;
    }

    void OnMouseDown()
    {
        windows.Organize(window.transform);
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && tabLock == false)
        {
            if (window.transform.position.z != 0) windows.Organize(window.transform);
            mousePosBegan = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            windowBegan = window.transform.position;
            tabLock = true;
        }
    }

    void OnMouseUp()
    {
        if (tabLock) tabLock = false;
    }
}
