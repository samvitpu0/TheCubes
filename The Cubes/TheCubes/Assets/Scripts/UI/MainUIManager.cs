using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIManager : MonoBehaviour
{
    [Header("Text assosiated with level number")]
    public Text levelNumber;

    [Header("Text assosiated with player score")]
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        levelNumber.text = Global.Level.ToString();
        MainController.UpdateScore += UpdateScoreUI;

        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = Global.Score.ToString();
    }

    private void OnDestroy()
    {
        MainController.UpdateScore -= UpdateScoreUI;
    }

}
