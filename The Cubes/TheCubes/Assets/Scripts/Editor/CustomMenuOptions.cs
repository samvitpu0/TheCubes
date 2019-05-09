using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomMenuOptions : EditorWindow
{
    [MenuItem("Custom Data Modifier/Delete All Save Data")]
    static void DeleteAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    [MenuItem("Custom Data Modifier/Reset Coins")]
    static void ResetCoins()
    {
        PlayerPrefs.DeleteKey(Global.COINS_KEY);
    }

    [MenuItem("Custom Data Modifier/Reset Diamonds")]
    static void ResetDiamonds()
    {
        PlayerPrefs.DeleteKey(Global.DIAMONDS_KEY);
    }

    [MenuItem("Custom Data Modifier/Reset Level")]
    static void ResetLevel()
    {
        PlayerPrefs.DeleteKey(Global.LEVEL_KEY);
    }
}
