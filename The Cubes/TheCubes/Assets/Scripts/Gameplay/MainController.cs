using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public GameObject fingerTrail;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            fingerTrail.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            fingerTrail.SetActive(true);
        }
        else
        {
            fingerTrail.SetActive(false);
        }
    }
}
