using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyUIElement : MonoBehaviour
{
    void Awake()
    {
        
    }

    void Start()
    {
        CurrencyController._instance.CurrencyChanged += UpdateUI;
        UpdateUI();
    }

    private void UpdateUI()
    {
        Debug.Log("UpdateUI");
        if(this.gameObject.name.Contains("Coin"))
        {
            var _coinText = GetComponent<Text>();
            _coinText.text = Global.Coins.ToString();
        }

        if(this.gameObject.name.Contains("Diamond"))
        {
            var _diamondText = GetComponent<Text>();
            _diamondText.text = Global.Diamonds.ToString();
        }
    }

    void OnDestroy()
    {
        CurrencyController._instance.CurrencyChanged -= UpdateUI;
    }
}
