using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject[] inactiveOnStart;
    public GameObject[] activeOnStart;

    void Start()
    {
        foreach(GameObject go in inactiveOnStart)
        {
            go.SetActive(false);
        }

        foreach(GameObject go in activeOnStart)
        {
            go.SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
