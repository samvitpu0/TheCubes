﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    /// <summary>
    /// Key that will be used to access the value of coins from playerr prefs
    /// </summary>
    public static string COINS_KEY = "COINS";

    /// <summary>
    /// Key that will be used to access the value of diamonds from playerr prefs
    /// </summary>
    public static string DIAMONDS_KEY = "DIAMONDS";

    /// <summary>
    /// Key that will be used to access the value of diamonds from playerr prefs
    /// </summary>
    public static string LEVEL_KEY = "LEVEL";
    
    // Default Coins and Diamonds given to the player    
    private const int DEFAULT_COINS = 100;
    private const int DEFAULT_DIAMONDS = 3;

    // Initial level
    private const int DEFAULT_LEVEL = 1;

    /// <summary>
    /// Value of coins with getter and setter
    /// getter will return the current value of coins and
    /// setter will set new value to player prefs
    /// </summary>
    public static int Coins
    {
        get
        {
            return PlayerPrefs.GetInt(COINS_KEY, DEFAULT_COINS);
        }

        set
        {
            PlayerPrefs.SetInt(COINS_KEY, value);
        }
    }

    /// <summary>
    /// Value of diamonds with getter and setter
    /// getter will return the current value of diamonds and
    /// setter will set new value to player prefs
    /// </summary> 
    public static int Diamonds
    {
        get
        {
            return PlayerPrefs.GetInt(DIAMONDS_KEY, DEFAULT_DIAMONDS);
        }

        set
        {
            PlayerPrefs.SetInt(DIAMONDS_KEY, value);
        }
    }

    /// <summary>
    /// Value of Level with getter and setter
    /// getter will return the current value of Level and
    /// setter will set new value to player prefs
    /// </summary>
    public static int Level
    {
        get
        {
            return PlayerPrefs.GetInt(LEVEL_KEY, DEFAULT_LEVEL);
        }

        set
        {
            PlayerPrefs.SetInt(LEVEL_KEY, value);
        }
    }
}
