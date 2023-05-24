using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class app_controller : MonoBehaviour
{
    [SerializeField] windows_manager windows;
    [SerializeField] GameObject target;

    void OnMouseDown()
    {
        if (!target.activeSelf) target.SetActive(true);
        target.transform.position = new Vector3(0, 0, target.transform.position.z);
        windows.Organize(target.transform);
    }
}
