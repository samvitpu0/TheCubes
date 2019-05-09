using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MianUIManager : MonoBehaviour
{
    [Header("Text assosiated with level number")]
    public Text levelNumber;


    // Start is called before the first frame update
    void Start()
    {
        levelNumber.text = Global.Level.ToString();    
    }

}
