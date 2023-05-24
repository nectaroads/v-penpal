using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windows_manager : MonoBehaviour
{
    [SerializeField] GameObject[] objects;

    void Start()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].GetComponent<Transform>().position = new Vector3(0, 0, i);
        }
    }

    public void Organize(Transform o)
    {
        for(int i = 0; i < objects.Length; i++)
        {
            objects[i].GetComponent<Transform>().position = new Vector3(objects[i].GetComponent<Transform>().position.x, objects[i].GetComponent<Transform>().position.y, objects[i].GetComponent<Transform>().position.z + 2);
        }
        o.transform.position = new Vector3(o.transform.position.x, o.transform.position.y, 0);
    }
}
