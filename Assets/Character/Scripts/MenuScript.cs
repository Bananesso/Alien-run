using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject layerOn;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            layerOn.gameObject.SetActive(true);
        }
    }
}