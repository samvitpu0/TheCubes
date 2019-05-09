using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CurrencyController : MonoBehaviour
{
    /// <summary>
    /// This instance will be used to Credit / Debit the currency
    /// </summary>
    public static CurrencyController _instance;

    /// <summary>
    /// This event will be called when ever there is a change in the currency values this can be used to
    /// update UI accordingly.
    /// </summary>
    public Action CurrencyChanged;

    void Awake()
    {

        if (_instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            _instance = this;
        }
    }

    public void DebitCoins (int _value)
    {
        Global.Coins -= _value;
        CurrencyChanged();
    }

    public void CreditCoins (int _value)
    {
        Global.Coins += _value;
        CurrencyChanged();
    }

    public void DebitDiamonds(int _value)
    {
        Global.Diamonds -= _value;
        CurrencyChanged();
    }

    public void CreditDiamonds(int _value)
    {
        Global.Diamonds += _value;
        CurrencyChanged();
    }
}
