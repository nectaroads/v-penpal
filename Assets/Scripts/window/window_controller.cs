using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class window_controller : MonoBehaviour
{
    [SerializeField] windows_manager windows;

    void OnMouseDown()
    {
        windows.Organize(gameObject.transform);
    }
}
